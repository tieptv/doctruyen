using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truyen
{
    public partial class trangdau : Form
    {
        public trangdau()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class story
        {
            static public string ten;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            story.ten = "thandieu";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
