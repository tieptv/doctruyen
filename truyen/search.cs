using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace truyen
{
    class search
    {
        public int Search(String key, BindingSource source)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
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
                    return Int32.Parse(dr["id"].ToString());
                }
            }
            return -1;
        }


    }
}
