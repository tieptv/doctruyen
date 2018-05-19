using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace truyen
{
  
    class rule
    {
        public virtual bool check(String x)
        {
            return true;
        }
        public virtual void loi() { }

    }
    class rule1 : rule
    {
        public override bool check(String x)
        {
            String phuam = "bcdđghklmnpqrstvx";
            int dem = 0;
            int len = x.Length;
            if (!String.IsNullOrEmpty(x))
            {
                for (int i = 0; i < len; i++)
                    if (phuam.Contains(x[i].ToString()) == true) dem++;
                if (dem <= 5) return true;
                else return false;
            }
            return true;
        }
        public override void loi()
        {
            Console.WriteLine("từ chỉ có tối đa 5 phụ âm");
        }

    }
    class rule2 : rule
    {
        public override bool check(String x)
        {
            String[] capphu = { "th", "gh", "tr", "kh", "ph" };
            for (int i = 0; i < 5; i++) if (x.EndsWith(capphu[i]) == true) return false;
            return true;
        }
        public override void loi()
        {
            Console.WriteLine("cap phu am cuoi sai");
        }
    }
    class rule3 : rule
    {
        public override bool check(String x)
        {
            String nguyenam = "aăâeêyoôơiuư";
            int len = x.Length;
            int dem = 0;
            if (!String.IsNullOrEmpty(x))
            {
                for (int i = 0; i < len; i++)
                    if (nguyenam.Contains(x[i].ToString()) == true) dem++;
                if (dem <= 3) return true;
                else return false;
            }
            return true;
        }
        public override void loi()
        {
            Console.WriteLine("từ chỉ có tối đa 3 nguyên âm");
        }
    }


    // s
    // s không đứng đầu các tiềng có âm đệm (oa, oă, oe, uê, uâ) ngoại trừ các trường hợp: soát, soạt, soạng, soạn, suất.
    class ruleS : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str[0] == 's')
                {
                    String[] tu = { "soát", "soạt", "soạng", "soạn", "suất", "soái" };
                    foreach (var s in tu)
                        if (str == s)
                            return true;

                    if (str.Length >= 3)
                    {
                        if (str[1] == 'o')
                        {
                            String[] van = { "oa", "oá", "oà", "oả", "oã", "oạ", "oă", "oắ", "oằ", "oẳ", "oẵ", "oặ", "oe", "oé", "oè", "oẻ", "oẽ", "oẹ" };
                            foreach (var s in van)
                                if (str.Substring(1, 2) == s)
                                    return false;
                        }
                        if (str[1] == 'u')
                        {
                            String[] van = { "uê", "uế", "uề", "uể", "uễ", "uệ", "uâ", "uấ", "uầ", "uẩ", "uẫ", "uậ" };
                            foreach (var s in van)
                                if (str.Substring(1, 2) == s)
                                    return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }

    // n - giống s
    // n  không đứng đầu các tiếng có vần có âm đệm (oa, oe, uâ, uy) trừ hai âm tiết Hán Việt: noãn, noa
    class ruleN : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str[0] == 'n')
                {
                    String[] tu = { "noãn", "noa" };
                    foreach (var s in tu)
                        if (str == s)
                            return true;

                    if (str.Length >= 3)
                    {
                        if (str[1] == 'o')
                        {
                            String[] van = { "oa", "oá", "oà", "oả", "oã", "oạ", "oe", "oé", "oè", "oẻ", "oẽ", "oẹ" };
                            foreach (var s in van)
                                if (str.Substring(1, 2) == s)
                                    return false;
                        }
                        if (str[1] == 'u')
                        {
                            String[] van = { "uâ", "uấ", "uầ", "uẩ", "uẫ", "uậ", "uy", "uỳ", "uý", "uỷ", "uỹ", "uỵ" };
                            foreach (var s in van)
                                if (str.Substring(1, 2) == s)
                                    return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }

    // tr
    // tr không đứng đầu các tiếng có vần âm đệm (oa, oă, oe, uê)
    class ruleTr : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str.Length >= 4)
                {
                    if (str.Substring(0, 2) == "tr")
                    {
                        if (str[2] == 'o')
                        {
                            String[] van = { "oa", "oá", "oà", "oả", "oã", "oạ", "oă", "oắ", "oằ", "oẳ", "oẵ", "oặ", "oe", "oé", "oè", "oẻ", "oẽ", "oẹ" };
                            foreach (var s in van)
                                if (str.Substring(2, 2) == s)
                                    return false;
                        }
                        if (str[2] == 'u')
                        {
                            String[] van = { "uê", "uế", "uề", "uể", "uễ", "uệ" };
                            foreach (var s in van)
                                if (str.Substring(2, 2) == s)
                                    return false;
                        }
                    }
                    return true;
                }
                return true;
            }
            return false;
        }
    }


    // gi, r - giống tr
    // Chữ r và gi không đứng đầu các tiềng có vần có âm đệm (oa, oe, uê, uy), ngoại lệ: ruy băng
    class ruleGiR : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str == "ruy")
                    return true;
                String[] van1 = { "oa", "oá", "oà", "oả", "oã", "oạ", "oe", "oé", "oè", "oẻ", "oẽ", "oẹ" };
                String[] van2 = { "uy", "uỳ", "uý", "uỷ", "uỹ", "uỵ", "uê", "uế", "uề", "uể", "uễ", "uệ" };
                if (str.Length >= 3)
                {
                    if (str[0] == 'r')
                    {
                        if (str[1] == 'o')
                            foreach (var s in van1)
                                if (str.Substring(1, 2) == s)
                                    return false;
                        if (str[1] == 'u')
                            foreach (var s in van2)
                                if (str.Substring(1, 2) == s)
                                    return false;
                    }

                    if (str.Substring(0, 2) == "gi")
                    {
                        if (str.Length >= 4)
                        {
                            if (str[2] == 'o')
                                foreach (var s in van1)
                                    if (str.Substring(2, 2) == s)
                                        return false;
                            if (str[2] == 'u')
                                foreach (var s in van2)
                                    if (str.Substring(2, 2) == s)
                                        return false;
                        }
                    }
                    return true;
                }
                return true;
            }
            return false;
        }
    }

    // q, k, c
    // q luôn bao giờ cũng đi với âm đệm u để thành qu; 
    // c ko đứng trước các nguyên âm: i, e, ê.
    // k luôn đứng trước các nguyên âm: i, e, ê.
    class ruleKC : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str.Length >= 2)
                {
                    Char[] nguyenAm = { 'i', 'í', 'ì', 'ỉ', 'ĩ', 'ị', 'e', 'è', 'é', 'ẻ', 'ẽ', 'ẹ', 'ê', 'ề', 'ế', 'ể', 'ễ', 'ệ', 'y', 'ỳ', 'ý', 'ỷ', 'ỹ', 'ỵ' };

                    if (str[0] == 'c')
                        foreach (var s in nguyenAm)
                            if (str[1] == s)
                                return false;

                    if (str[0] == 'k')
                    {
                        foreach (var s in nguyenAm)
                            if (str[1] == s)
                                return true;
                        if (str[1] == 'h')
                            return true;
                        return false;
                    }

                    return true;
                }
                return true;
            }
            return false;
        }
    }

    // ng-ngh
    // thêm h khi có i, e, ê đứng sau và ngược lại
    class ruleNgNgh : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str.Length >= 3)
                {
                    Char[] nguyenAm = { 'i', 'ì', 'ì', 'ỉ', 'ĩ', 'ị', 'e', 'è', 'é', 'ẻ', 'ẽ', 'ẹ', 'ê', 'ề', 'ế', 'ể', 'ễ', 'ệ' };
                    if (str.Substring(0, 2) == "ng")
                        foreach (var s in nguyenAm)
                            if (str[2] == s)
                                return false;

                    if (str.Substring(0, 3) == "ngh")
                    {
                        foreach (var s in nguyenAm)
                            if (str[3] == s)
                                return true;

                        return false;
                    }
                    return true;
                }
                return true;
            }
            return false;
        }
    }
    class ruleQ : rule
    {
        public override bool check(String str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                if (str.Length >= 3)
                {
                    if ((str[0] == 'q') && (str[1] != 'u'))
                        return false;
                }
                return true;

            }
            return false;
        }
    }


 class Luat{
     public List<rule> add()
     {
         List<rule> t = new List<rule>();
         rule1 r1 = new rule1();
         rule2 r2 = new rule2();
         rule3 r3 = new rule3();
         ruleGiR r4 = new ruleGiR();
         ruleN r5 = new ruleN();
         ruleNgNgh r6 = new ruleNgNgh();
         ruleKC r7 = new ruleKC();
         ruleS r8 = new ruleS();
         ruleTr r9 = new ruleTr();
         ruleQ r10 = new ruleQ();
         t.Add(r1);
         t.Add(r2);
         t.Add(r3);
         t.Add(r4);
         t.Add(r5);
         t.Add(r6);
         t.Add(r7);
         t.Add(r8);
         t.Add(r9);
         t.Add(r10);
         return t;
     }
     public List<String> checkLuat(String noidung, List<rule> t)
     {
         String[] separators = { ",", ".", "!", "?", ";", ":", " ","-","\n" };
         String[] words = noidung.Split(separators, StringSplitOptions.RemoveEmptyEntries);
         List<String> wrong = new List<String>();
         int len = words.Length;

         for (int j = 0; j < len; j++)
         {
             for (int i = 0; i < 10; i++) if (t[i].check(words[j]) == false)
                 {
                     Console.WriteLine(i);
                     wrong.Add(words[j]);
                     break;

                 }
                 else continue;

         }

         return wrong;
     }

 }





}
