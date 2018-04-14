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
       SqlConnection con;
        SqlDataAdapter adapter;
        DataTable table;
       BindingSource source;
       List<rule> luat = new List<rule>();
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
             source.Add(tiep);
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
            //set cho listview
            list.Items.Clear();
            String cau = searchBox.Text;
            search s = new search();
            int ch = s.Search(cau, source);
            list.Items.Add(ch.ToString());

        }

        private void noidung_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


      
    }
}
