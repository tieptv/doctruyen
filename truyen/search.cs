using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;

namespace truyen
{
    class search
    {
        private int n;
        private ArrayList[] w;
        int[] p = new int[n];

        private int min = w[0].ToArray[0], max = w[0].ToArray[0], S, Smin = -1;

        private void process()
        {

        }

        private void TRY(int k)
        {
            foreach(int v in w[k])
            {
                if ()
                {
                    p[k] = v;
                    if (k == n-1)
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
        
        private void findBest()
        {
            int[] p = new int[n];
            for (int i = 0; i < n; i++)
            {
                w[i].ToArray();
            }

            min = 999999999;
            max = -1;
            Smin = 99999999;

         
            for(int j = 0; j < n; j++)
            {
                foreach(int k in w[j])
                {
                    if (k > max)
                    {
                        max = k;
                        S = max - min;
                        if (S < Smin)
                        {
                            p[j] = k;
                            Smin = S;
                        }
                    }
                    if (k < min)
                    {
                        min = k;
                        S = max - min;
                        if (S < Smin)
                        {
                            p[j] = k;
                            Smin = S;
                        }
                    }
                }
            }


            
        }

        public String Search(String key, BindingSource source, out int chapter)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "\t", "\n" };
            String[] words = key.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach(DataRow dr in source)
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
                    

                    for (int i = 0; i < n; i++)
                    {
                        int index = 0;
                        while ((index = noiDung.IndexOf(words[i], index)) != -1)
                        {
                            w[i].Add(index);
                        }
                    }

                    findBest();
                    


                }
            }
            chapter = -1;
            return null;
        }


    }
}
