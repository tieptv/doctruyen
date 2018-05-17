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
        private static int n; //Số lượng từ tìm kiếm có trong 1 chương, dùng cho TRY
        private static ArrayList[] w; //Chứa bản đồ các chỉ số của các từ khóa, dùng cho TRY

        private static int[] A; //Chứa phương hiện thời, dùng cho TRY
        private static int S; //Hiệu của 2 chỉ số từ lớn nhất và nhỏ nhất, của phương án hiện thời
        private static Stack<int> max = new Stack<int>(); //Đỉnh stack chứa chỉ số lớn nhất của các từ khóa, trong phương án hiện thời
        private static Stack<int> min = new Stack<int>(); //Đỉnh stack chứa chỉ số nhỏ nhất của các từ khóa, trong phương án hiện thời


        private static int[] B; //Chứa phương án tốt nhất đã tìm được, dùng cho TRY
        private static int S_best, max_best, min_best;//Tương tự S, max, min nhưng của phương án tốt nhất

        private static String[] separators = { " ", ",", ".", "!", "?", ";", ":", "\t", "\n", "\r", "-" }; //Các ký tự kết thúc từ, dùng để tách từ


        //Summary:
        //    Tìm chỉ số của 1 từ độc lập trong 1 xâu(từ ấy phải đứng trước dấu cách
        //    hoặc ít nhất 1 dấu câu, khoảng trắng).

        //Parameters:
        //    source:
        //        Nguồn tìm kiếm.

        //    value:
        //        Từ cần tìm.

        //    startIndex:
        //        Vị trí bắt đầu tìm kiếm.

        //    comparisonType:
        //        Một trong những giá trị enum của luật tìm kiếm.

        //Returns:
        //    Trả về chỉ số của value trong source nếu tìm thấy, trả về -1 nếu
        //    không tìm được, 0 nếu value là System.String.Empty
        public static int IndexOf(String source, String value, int startIndex, StringComparison comparisonType)
        {
            int index = source.IndexOf(value, startIndex, comparisonType);

            if (index == -1 || index == 0)
                return index;

            foreach (String sepa in separators)
            {
                if ((index = source.IndexOf(value + sepa, startIndex, comparisonType)) != -1)
                    return index;
            }
            return -1;
        }

        //Summary:
        //    Tìm chỉ số của 1 từ độc lập trong 1 xâu (từ ấy phải đứng trước dấu cách 
        //    hoặc ít nhất 1 dấu câu, khoảng trắng).

        //Parameters:
        //    source:
        //        Nguồn tìm kiếm.

        //    value:
        //        Từ cần tìm.

        //    comparisonType:
        //        Một trong những giá trị enum của luật tìm kiếm.

        //Returns:
        //    Trả về chỉ số của value trong source nếu tìm thấy, trả về -1 nếu
        //    không tìm được, 0 nếu value là System.String.Empty
        public static int IndexOf(String source, String value, StringComparison comparisonType)
        {
            int index = source.IndexOf(value, comparisonType);

            if (index == -1 || index == 0)
                return index;
            
            foreach (String sepa in separators)
            {
                if ((index = source.IndexOf(value + sepa, comparisonType)) != -1)
                    return index;
            }
            return -1;
        }

        //Summary:
        //    Xét kết quả thử của vòng đệ quy TRY. Nếu nó ngắn hơn kết quả tốt nhất 
        //    hiện tại, thì cập nhật phương án tốt nhất.
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

        //Summary:
        //    Vòng đệ quy quay lui thử các kết quả tìm kiếm.
        private static void TRY(int k)
        {
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

        //Summary:
        //    Tìm kết quả ngắn nhất trong 1 chương.

        //Parameters:
        //    noiDung: 
        //        Xâu chứa nội dung của chương cần tìm kiếm.

        //    key_words:
        //        Mảng chứa từ khóa cần tìm đã được tách thành từng từ một.

        //Returns:
        //    Xâu con ngắn nhất của noiDung, chứa các từ trong key_words (có thể không 
        //    đầy đủ hết các từ khóa).
        //    Trả về null nếu noiDung hoặc key_words rỗng.
        private static String FindBest(String noiDung, String[] key_words)
        {
            n = key_words.Length; //Số lượng từ khóa

            if (noiDung == null || n == 0) //Nội dung chương rỗng hoặc không có từ khóa
                return null;

            w = new ArrayList[n];//Chứa các chỉ số của các từ khóa

            String[] words = new String[n]; //Chứa các từ khóa có trong chương
            Array.Copy(key_words, words, n);

            //Duyệt qua từng từ khóa
            for (int i = 0; i < n; i++)
            {
                int index = -1;

                if (IndexOf(noiDung, words[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    //Từ khóa có trong chương này

                    w[i] = new ArrayList();

                    //Tìm tât cả vị trí, thêm vào w
                    while ((index = IndexOf(noiDung, words[i], index + 1, StringComparison.CurrentCultureIgnoreCase)) != -1)
                    {
                        w[i].Add(index);
                    }
                }
                else
                {
                    //Từ khóa không có trong chương, xóa bỏ từ này trong words[]
                    for (int j = i + 1; j < n; j++)
                    {
                        words[j - 1] = words[j];
                    }
                    n--;
                    i--;
                }

            }

            //Khởi tạo cho vòng TRY
            min_best = Int32.MaxValue;
            max_best = -1;

            A = new int[n];//Chứa phương án hiện thời
            B = new int[n];//Chứa phương án tốt nhất

            //Khởi tạo phương án đầu tiên, lưu vào phương án tốt nhất
            for (int i = 0; i < n; i++)
            {
                int temp = (int)w[i][0];
                A[i] = 0;
                B[i] = 0;
                if (temp < min_best)
                    min_best = temp;
                
                if (temp > max_best)
                    max_best = temp;
            }
            S_best = max_best - min_best;


           //Bắt đầu thử các phương án
            TRY(0);

            //Tìm từ cuối cùng xấu hiện trong phương án
            int max_word_index;
            for (max_word_index = 0; max_word_index < n - 1; max_word_index++)
            {
                if (w[max_word_index].IndexOf(max_best) != -1)
                    break;
            }

            //Kết quả trả về: xâu con của chương, bắt đầu từ min_best (từ khóa có chỉ số bé nhất)
            //S_best: khoảng cách từ chỉ số chữ cuối cùng đến chữ đầu tiên của kết quả,
            //vẫn chưa bao phủ hết chữ cuối cùng, nên cộng thêm words[max_word_index].Length (chiều dài của chữ cuối cùng).
            return (noiDung.Substring(min_best, S_best + words[max_word_index].Length));

        }

        //Summary:
        //    Tìm kiếm nội dung trong truyện.
        
        //Parameters:
        //    key:
        //        Xâu nội dung cần tìm kiếm. Nếu xâu rỗng hoặc không có từ khóa, 
        //        hàm trả về null.

        //    source:
        //        Chứa dữ liệu các chương của truyện.

        //Returns:
        //    ArrayList chứa các kết quả tìm được dưới dạng SearchResult, đã được sắp xếp 
        //    theo lớp so sánh SearchResultComparer, với độ ưu tiên:
        //    độ dài kết quả (càng ngắn càng ở trước), số lượng từ trùng khớp trong
        //    key (đủ chữ ở trước), đúng thứ tự hay không đúng thứ tự, cuối cùng là 
        //    số chương.
        public static ArrayList Search(String key, BindingSource source)
        {
            //Tách key thành từng từ một
            String[] key_words = key.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (key_words.Length == 0) //Nếu không có từ khóa nào
            {
                return null;           //Trả về null
            }

            ArrayList search_result = new ArrayList(); //Chứa kết quả trả về
            foreach (DataRow dr in source)//Duyệt qua từng chương
            {
                String noiDung = dr["noidung"].ToString(); //Nội dung của chương

                int count = 0; //Đếm số từ khóa tìm được trong chương
                int miss = 0; //Đếm số từ khóa không tồn tại trong chương

                foreach (String word in key_words) //Duyệt các từ khóa
                {
                    //Nếu tìm thấy từ kóa trong chương
                    if (IndexOf(noiDung, word, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        count++;
                    }
                    else //Không thấy từ khóa trong chương
                    {
                        miss++;
                        if (miss * 100 / key_words.Length > 20) //Thiếu 20% từ khóa thì thoát, không tìm nữa
                            break;
                    }
                }
                int match = count * 100 / key_words.Length; //Độ trùng khớp, phần trăm từ khóa có trong chương
                if (match >= 80) //Có ít nhất 80% từ khóa trong chương
                {
                    int chapter = Int32.Parse(dr["id"].ToString()); //Số thứ tự Chương

                    String sr = FindBest(noiDung, key_words); //Tìm trong chương

                    //Kiểm tra trong kết quả trả về, các từ khóa có đúng thứ tự không
                    bool orderly = true;
                    for (int i = 1; i < B.Length; i++)
                    {
                        if ((int)w[i][B[i]] < (int)w[i - 1][B[i - 1]])
                        {
                            orderly = false;
                            break;
                        }
                    }

                    //Thêm kết quả vừa tìm được vào danh sách kết quả
                    search_result.Add(new SearchResult(sr, chapter, min_best, match, orderly));

                }
            }

            //Sắp xếp danh sách kết quả theo các độ ưu tiên: độ ngắn gọn, đủ số lượng từ, đúng thứ tự
            search_result.Sort(new SearchResultComparer());

            return search_result;
        }
    }


    //Summary:
    //    Kết quả tìm kiếm
    public class SearchResult
    {
        public String phrase { get; set; } //Đoạn tìm kiếm được
        public int chapter { get; set; } //Chương 
        public int indexInChapter { get; set; } //Chỉ số bắt đầu trong chương
        public int length { get; set; } //Chiều dài của kết quả
        public int match; //Độ trùng khớp với key tìm kiếm, đơn vị phần trăm
        public bool orderly; //Các từ khóa có đúng thứ tự trong kết quả hay không ?

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

    //Summay:
    //    Lớp so sánh 2 kết quả tìm kiếm.
    public class SearchResultComparer : IComparer
    {
        //Summary:
        //    So sánh 2 đối tượng SearchResult.

        //Parameters:
        //    x, y:
        //      2 đối tượng cần so sánh.

        //Returns:
        //    Âm nếu x có độ ưu tiên cao hơn (ngắn hơn, trùng khớp nhiều hơn...)
        //    Dương nếu ngược lại.
        //    0 nếu bằng nhau.
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
