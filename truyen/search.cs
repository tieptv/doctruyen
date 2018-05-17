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
    public class search
    {
        private static int n;
        private static ArrayList[] w;
        private static int[] A; //solution
        private static int[] B; //best solution
        private static int S, S_best, max_best, min_best;
        private static Stack<int> max = new Stack<int>();
        private static Stack<int> min = new Stack<int>();
        private static String[] separators = { " ", ",", ".", "!", "?", ";", ":", "\t", "\n", "\r", "-" };

        public static int IndexOf(String source, String value, int startIndex, StringComparison comparisonType)
        {
            if (source.IndexOf(value, startIndex, comparisonType) == -1)
                return -1;
            int index;
            foreach(String sepa in separators)
            {
                if ((index = source.IndexOf(value + sepa, startIndex, comparisonType)) != -1)
                    return index;
            }
            return -1;
        }
        public static int IndexOf(String source, String value, StringComparison comparisonType)
        {
            if (source.IndexOf(value, comparisonType) == -1)
                return -1;
            int index;
            foreach (String sepa in separators)
            {
                if ((index = source.IndexOf(value + sepa, comparisonType)) != -1)
                    return index;
            }
            return -1;
        }

        private static void process()
        {
            
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

        private static String FindBest(String noiDung, String[] key_words)
        {
            n = key_words.Length;
            w = new ArrayList[n];
            String[] words = new String[n];
            Array.Copy(key_words, words, n);

            for (int i = 0; i < n; i++)
            {
                int index = -1;
                if (IndexOf(noiDung, words[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    w[i] = new ArrayList();

                    while ((index = IndexOf(noiDung, words[i], index + 1, StringComparison.CurrentCultureIgnoreCase)) != -1)
                    {
                        w[i].Add(index);
                    }
                }
                else
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        words[j - 1] = words[j];
                    }
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


           // Console.WriteLine("TRY");
            TRY(0);

            int max_word_index;

            for (max_word_index = 0; max_word_index < n - 1; max_word_index++)
            {
                if (w[max_word_index].IndexOf(max_best) != -1)
                    break;
            }

            return (noiDung.Substring(min_best, S_best + words[max_word_index].Length));

        }

        public static ArrayList Search(String key, BindingSource source)
        {
            String[] key_words = key.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            ArrayList search_result = new ArrayList();
            foreach (DataRow dr in source)
            {
                String noiDung = dr["noidung"].ToString();

                int count = 0;
                int miss = 0;

                foreach (String word in key_words)
                {
                    if (IndexOf(noiDung, word, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        count++;
                    }
                    else
                    {
                        miss++;
                        if (miss * 100 / key_words.Length > 20)
                            break;
                    }
                }
                int match = count * 100 / key_words.Length;
                if (match >= 80)
                {
                    int chapter = Int32.Parse(dr["id"].ToString());
                    String sr = FindBest(noiDung, key_words);
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

            //IComparer myComparer = new SearchResultComparer();
            search_result.Sort(new SearchResultComparer());
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
