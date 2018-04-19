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
        private int n;
        private ArrayList[] w;
        private int[] A; //solution
        private int[] B; //best solution
        private int max, min, S, Smin;

        private void process()
        {
            int k = 0;
            foreach (int i in A)
            {
                int t = (int)w[k][i];
                if (t < min)
                    min = t;
                if (t > max)
                    max = t;
                k++;
            }
            S = max - min;
            if (S < Smin)
            {
                Smin = S;
                Array.Copy(A, B, A.Length);

            }
        }

        private void TRY(int k)
        {
            for (int v = A[k] + 1; v < w[k].Count; v++)
            {
                if (k == 0)
                {
                    max = min = (int)w[k][v];
                }
                else
                {
                    int t = (int)w[k][v];
                    if (t < min)
                        min = t;
                    if (t > max)
                        max = t;
                    if (max - min <= Smin)
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
                }
            }

        }


        public String Search(String key, BindingSource source, out int chapter)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "\t", "\n" };
            String[] words = key.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (DataRow dr in source)
            {
                String noiDung = dr["noidung"].ToString();
                bool flag = true;
                foreach (String word in words)
                {
                    if (!noiDung.Contains(word))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    chapter = Int32.Parse(dr["id"].ToString());
                    n = words.Length;
                    w = new ArrayList[n];
                    A = new int[n];
                    B = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        int index = -1;
                        w[i] = new ArrayList();
                        while ((index = noiDung.IndexOf(words[i], index + 1)) != -1)
                        {
                            w[i].Add(index);
                        }

                    }

                    //Init for TRY()
                    min = Int32.MaxValue;
                    max = -1;

                    for (int i = 0; i < n; i++)
                    {
                        A[i] = 0;
                        int temp = (int)w[i][0];
                        if (temp < min)
                            min = temp;

                        //int temp = (int)w[i][w[i].Count];
                        if (temp > max)
                            max = temp;
                    }
                    Smin = max - min;

                    TRY(0);
                    //findBest();

                    return (noiDung.Substring(min, Smin));


                }
            }
            chapter = -1;
            return null;
        }


    }
}
