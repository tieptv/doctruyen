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
       SqlConnection con;
        SqlDataAdapter adapter;
        DataTable table;
       BindingSource source;
       List<rule> luat = new List<rule>();
       List<String> chapter = new List<String>();
        private void connect()
        { 

        } 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
            noidung.SelectionStart = 0;
            noidung.ScrollToCaret();
            showrecord();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            source.MoveNext();
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
        Luat l = new Luat();
        DataRow currentRow=(DataRow)source.Current;
        noidung.Text=currentRow["noidung"].ToString();
        List<String> words = l.checkLuat(noidung.Text, luat);
       foreach(String w in words)changeColor(noidung,w);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    

        private void list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //khi click vào listview thì hiển thị lên chương đó
            var item = e.Item;
            source.Position = Int32.Parse(item.Text)-1;
            showrecord();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void search_Click(object sender, EventArgs e)
        {
           // int chapter=9;
            //set cho listview
         //   list.Items.Clear();
         //   String cau = searchBox.Text;
           // search s = new search();
          //  String ch = s.Search(cau, source, out chapter);
          //  ListViewItem k = new ListViewItem(chapter.ToString());
          //  ListViewItem.ListViewSubItem k1 = new ListViewItem.ListViewSubItem(k, "20.000 sinh viên");
          //  k.SubItems.Add(k1);
          //  list.Items.Add(k);
            

        }

      
       

        private void ds_chuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ds_chuong_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            for (int i = 0; i < ds_chuong.Items.Count; i++)
            {
                if (ds_chuong.Items[i].Selected)
                {
                    source.Position = i;
                    showrecord();
                    break;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
             if(lamp==0){
                 this.BackColor = Color.Black;
                 this.button1.Visible = false;
                 this.button2.Visible = false;
                 this.button3.Visible = false;
                 this.tabControl1.Visible = false;
                 this.label1.Visible = false;
               this.den.Text = "Bật đèn";
               lamp = 1;
             }
             else {
                 this.BackColor = Color.Aqua;
                 this.button1.Visible = true;
                 this.button2.Visible = true;
                 this.button3.Visible = true;
                 this.tabControl1.Visible = true;
                 this.label1.Visible = true;
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



      
    }
}
