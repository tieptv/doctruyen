using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace truyen
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }
        int zoom=1;
        int lamp = 0;
        music mc = new music();
       // music tat_den = new music();
       // music chinh_ta = new music();
       SqlConnection con;
        SqlDataAdapter adapter;
        DataTable table;
       BindingSource source;
       List<rule> luat = new List<rule>();
       List<String> chapter = new List<String>();
       ArrayList search_result;// toàn cục
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
            ds_chuong.SelectedIndex = source.Position;
            noidung.SelectionStart = 0;
            noidung.ScrollToCaret();
            showrecord();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            source.MoveNext();
            ds_chuong.SelectedIndex = source.Position;
            noidung.SelectionStart = 0;
            noidung.ScrollToCaret();
            showrecord();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            //set dữ liệu cho combobox
            for (int i = 8; i <= 72; i++) textSize.Items.Add(i.ToString());
            //-----------Tạo danh sách font chữ
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                textFont.Items.Add(family.Name.ToString());
            }
            //hoàn tất set dữ liệu
            label1.Text = trangdau.story.ten_truyen;
         
            mc.OpenMediaFile(trangdau.story.ten+".mp3");
            mc.PlayMediaFile(false);//hết bài dừng không lặp lại, true lặp lại
           
            Dinhdang();
            Luat ad = new Luat();
            luat=ad.add();
            connect cn = new connect();
            con = cn.conDB();
            String sql = "select * from " + trangdau.story.ten;
           adapter=new SqlDataAdapter(sql,con);
           table=new DataTable();
           adapter.Fill(table);
            source=new BindingSource();
         foreach(DataRow tiep in table.Rows)
             {
             source.Add(tiep);
             String ch = "Chương " + tiep["id"].ToString() + " : " + tiep["ten"];
             chapter.Add(ch);
             }
         foreach (String chap in chapter) ds_chuong.Items.Add(chap);

         showrecord();
       
        }
        private void showrecord(){
   
        DataRow currentRow=(DataRow)source.Current;
        noidung.Text=currentRow["noidung"].ToString();
       
       chuong.Text=currentRow["ten"].ToString();
       so.Text=currentRow["id"].ToString();
        }
        private void changeColor(RichTextBox ketqua, string sai)
        {
            
            int pos = ketqua.SelectionStart;
            string s = ketqua.Text;
            for (int ix = 0; ; )
            {
                int jx = s.IndexOf(sai, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0) break;
                ketqua.SelectionStart = jx;
                ketqua.SelectionLength = sai.Length;
                ketqua.SelectionColor = Color.Red;
                ix = jx + 1;
            }
            ketqua.SelectionStart = pos;
            ketqua.SelectionLength = 0; 
        }
        private void chuong_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void search_Click(object sender, EventArgs e)
        {
           
            list.Items.Clear();
          
            //set cho listview
            String key = searchBox.Text;
           
            search_result = search.Search(key,source);
            int len = search_result.Count;
            if(len>0){
            foreach (SearchResult s in search_result)
            {
                ListViewItem k = new ListViewItem(s.chapter.ToString());
                ListViewItem.ListViewSubItem k1 = new ListViewItem.ListViewSubItem(k,s.phrase);
                k.SubItems.Add(k1);
                list.Items.Add(k);
            
            }
            }
            else {
                ListViewItem k = new ListViewItem("Error:");
                ListViewItem.ListViewSubItem k1 = new ListViewItem.ListViewSubItem(k, "Không tìm thấy kết quả");
                k.SubItems.Add(k1);
                list.Items.Add(k);
            }
            
        }

      
       

       
   
        private void button4_Click(object sender, EventArgs e)
        {
            mc.ClosePlayer();
        
             if(lamp==0){
                 this.BackColor = Color.Black;
                 this.noidung.BackColor = Color.Black;
                 this.noidung.ForeColor = Color.White;
                 this.button1.Visible = false;
                 this.button2.Visible = false;
                 this.button3.Visible = false;
                 this.button4.Visible = false;
                 this.button5.Visible = false;
                 this.tabControl1.Visible = false;
                 this.label1.Visible = false;
                 this.label2.Visible = false;
                 this.so.Visible = false;
                 this.chuong.Visible = false;
                 this.BackgroundImage = null;
               this.den.Text = "Bật đèn";
               lamp = 1;
               mc.OpenMediaFile("tat_den.mp3");
               mc.PlayMediaFile(false);
             }
             else {
                 mc.ClosePlayer();
                 this.BackColor = Color.Aqua;
                 this.noidung.BackColor = Color.White;
                 this.noidung.ForeColor = Color.Black;
                 this.button1.Visible = true;
                 this.button2.Visible = true;
                 this.button3.Visible = true;
                 this.button4.Visible = true;
                 this.button5.Visible = true;
                 this.tabControl1.Visible = true;
                 this.label1.Visible = true;
                 this.label2.Visible = true;
                 this.so.Visible = true;
                 this.chuong.Visible = true;
                 this.BackgroundImage = truyen.Properties.Resources.anhnen;
                 this.den.Text = "Tắt đèn";
                 lamp = 0;
                 }
            
             
        }


        void Dinhdang()
        {
            float fsize = 14;//Kích thước mặc định
            if (textSize.SelectedIndex != -1)
                fsize = (float)float.Parse(textSize.SelectedItem.ToString());
            string fname = "Segoe UI";//Font thước mặc định
            if (textFont.SelectedIndex != -1)
                fname = textFont.SelectedItem.ToString();
            try
            {
                Font f = new Font(new FontFamily(fname), fsize);
                noidung.Font = f;
            }
            catch
            {
                MessageBox.Show("Font này không hỗ trợ kiểu hiển thị hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dinhdang();

        }

        private void textFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dinhdang();
        }

        private void noidung_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (zoom==1)
                {noidung.ZoomFactor = 2.0f;
                zoom = -1;
                }
            else {
                noidung.ZoomFactor = 1.0f;
                zoom = 1;
            }
        }

        private void button_music_Click(object sender, EventArgs e)
        {
          //  if (button_music.Text.Equals("Tắt nhạc"))
        //    {  mc.ClosePlayer();
        //    button_music.Text = "Bật nhạc";
        //    }
        //    else {
         //   mc.OpenMediaFile("thandieu.mp3");
         //   mc.PlayMediaFile(false);//hết bài dừng không lặp lại, true lặp lại
          //  button_music.Text = "Tắt nhạc";
          //  }
        }
       

        private void list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
         
          int i = 0; 
          
            for ( i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected) 
                    {
                        SearchResult s= search_result[i] as SearchResult;;
                        source.Position = s.chapter - 1;
                        
                       showrecord();
                   //    noidung.Find(s.phrase);
                       noidung.Select(s.indexInChapter,s.length);
                      noidung.SelectionColor = Color.Blue;
                      noidung.ScrollToCaret();
                    break;
                    }
            }
          
        
           
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
              
                   search_Click(sender,e);
                   
            }
                
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            mc.ClosePlayer();
           
            trangdau trang1 = new trangdau();
            this.Hide();
            trang1.Show();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            float fsize = 14;//Kích thước mặc định
            string fname = "Segoe UI";//Font thước mặc định
            Font f = new Font(new FontFamily(fname), fsize);
            noidung.Font = f;
          

        }

        private void ds_chuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            source.Position = ds_chuong.SelectedIndex;
            showrecord();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            mc.ClosePlayer();
            mc.OpenMediaFile("chinh_ta.mp3");
            mc.PlayMediaFile(false);
            Luat l = new Luat();
            List<String> words = l.checkLuat(noidung.Text, luat);
            foreach(String w in words)changeColor(noidung,w);

            
        }

       
      



      
    }
}
