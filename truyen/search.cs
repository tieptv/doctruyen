using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;

namespace truyen
{
    class search
    {
        private static int n;
        private static ArrayList[] w;
        private static int[] A; //solution
        private static int[] B; //best solution
        private static int S, S_best, max_best, min_best;
        private static Stack<int> max = new Stack<int>();
        private static Stack<int> min = new Stack<int>();
        private static int max_word_index;

        private static void process()
        {
            //int k = 0;
            //foreach (int i in A)
            //{
            //    int t = (int)w[k][i];
            //    if (t < min)
            //        min = t;
            //    if (t > max)
            //        max = t;
            //    k++;
            //}
            S = max.Peek() - min.Peek();
            if (S < S_best)
            {
                S_best = S;
                Array.Copy(A, B, A.Length);
                max_best = max.Peek();
                min_best = min.Peek();
            }
        }

        private static void TRY(int k)
        {
            //Console.WriteLine(k);
            for (int v = A[k]; v < w[k].Count; v++)
            {
                int t = (int)w[k][v];
                bool flag_max = false, flag_min = false;
                if (k == 0)
                {
                    min.Push(t);
                    max.Push(t);
                    flag_max = true;
                    flag_min = true;
                }
                else
                {

                    if (t < min.Peek())
                    {
                        min.Push(t);
                        flag_min = true;
                    }
                    if (t > max.Peek())
                    {
                        max.Push(t);
                        flag_max = true;
                    }
                }
                if (max.Peek() - min.Peek() < S_best)
                {
                    A[k] = v;

                    if (k == n - 1)
                    {
                        process();
                    }
                    else
                    {
                        TRY(k + 1);
                    }
                }
                if (flag_max)
                {
                    max.Pop();
                }
                if (flag_min)
                {
                    min.Pop();
                }
            }

        }

        private static String FindBest(String noiDung, String[] words)
        {
            n = words.Length;
            w = new ArrayList[n];

            for (int i = 0; i < n; i++)
            {
                int index = -1;
                if (noiDung.Contains(words[i]))
                {
                    w[i] = new ArrayList();
                    while ((index = noiDung.IndexOf(words[i], index + 1)) != -1)
                    {
                        w[i].Add(index);
                    }
                }
                else
                {
                    words[i] = words[n - 1];
                    n--;
                    i--;
                }

            }

            //Init for TRY()
            min_best = Int32.MaxValue;
            max_best = -1;

            A = new int[n];
            B = new int[n];
            for (int i = 0; i < n; i++)
            {

                int temp = (int)w[i][0];
                A[i] = 0;
                B[i] = 0;
                if (temp < min_best)
                    min_best = temp;

                //int temp = (int)w[i][w[i].Count];
                if (temp > max_best)
                    max_best = temp;
            }
            S_best = max_best - min_best;


            Console.WriteLine("TRY");
            TRY(0);



            for (max_word_index = 0; max_word_index < n; max_word_index++)
            {
                if (w[max_word_index].IndexOf(max_best) != -1)
                    break;
            }

            return (noiDung.Substring(min_best, S_best) + words[max_word_index]);

        }

        public ArrayList Search(String key, BindingSource source)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "\t", "\n" };
            String[] words = key.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            ArrayList search_result = new ArrayList();
            foreach (DataRow dr in source)
            {
                String noiDung = dr["noidung"].ToString();
                int count = 0;
                foreach (String word in words)
                {
                    if (noiDung.Contains(word))
                    {
                        count++;
                    }
                }
                int match = count * 100 / words.Length;
                if (match >= 80)
                {
                    int chapter = 1;
                    String sr = FindBest(noiDung, words);
                    bool orderly = true;
                    for (int i = 1; i < B.Length; i++)
                    {
                        if ((int)w[i][B[i]] < (int)w[i - 1][B[i - 1]])
                        {
                            orderly = false;
                            break;
                        }
                    }
                    search_result.Add(new SearchResult(sr, chapter, min_best, match, orderly));

                }
            }

            IComparer myComparer = new SearchResultComparer();
            search_result.Sort(myComparer);
            return search_result;
        }


    }

    public class SearchResult
    {
        public String phrase { get; set; }
        public int chapter { get; set; }
        public int indexInChapter { get; set; }
        public int length { get; set; }
        public int match;
        public bool orderly;

        public SearchResult(String phrase, int chapter, int indexInChapter, int match, bool orderly)
        {
            this.phrase = phrase;
            this.chapter = chapter;
            this.indexInChapter = indexInChapter;
            this.length = phrase.Length;
            this.match = match;
            this.orderly = orderly;
        }



    }

    public class SearchResultComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            SearchResult X = (SearchResult)x;
            SearchResult Y = (SearchResult)y;

            if (X.length != Y.length)
                return X.length - Y.length;
            else if (X.match != Y.match)
                return X.length - Y.length;
            else if (X.orderly != Y.orderly)
                return X.orderly ? -1 : 1;
            else
                return X.chapter - Y.chapter;
        }
    }
}
