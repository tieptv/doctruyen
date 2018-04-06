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
            showrecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            source.MoveNext();
            showrecord();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        DataRow currentRow=(DataRow)source.Current;
        noidung.Text=currentRow["noidung"].ToString();
       chuong.Text=currentRow["ten"].ToString();
       so.Text=currentRow["id"].ToString();
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
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void search_Click(object sender, EventArgs e)
        {
            //set cho listview

        }


      
    }
}
