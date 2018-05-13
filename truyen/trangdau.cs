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
            static public string ten_truyen;

        }

        private void trangdau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            story.ten = "thandieu";
            story.ten_truyen = "Thần Điêu Đại Hiệp";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void anh_hung_xa_dieu_Click(object sender, EventArgs e)
        {
            story.ten = "anh_hung_xa_dieu";
            story.ten_truyen = "Anh Hùng Xạ Điêu";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void tieu_ngao_giang_ho_Click(object sender, EventArgs e)
        {
            story.ten = "tieu_ngao_giang_ho";
            story.ten_truyen = "Tiếu Ngạo Giang Hồ";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void thien_long_bat_bo_Click(object sender, EventArgs e)
        {
            story.ten = "thien_long_bat_bo";
            story.ten_truyen = "Thiên Long Bát Bộ";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void y_thien_do_long_ky_Click(object sender, EventArgs e)
        {
            story.ten = "y_thien_do_long_ky";
            story.ten_truyen = "Ỷ Thiên Đồ Long Ký";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void loc_dinh_ky_Click(object sender, EventArgs e)
        {
            story.ten = "loc_dinh_ky";
            story.ten_truyen = "Lộc Đienh Ký";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void tuyet_son_phi_ho_Click(object sender, EventArgs e)
        {
            story.ten = "tuyet_son_phi_ho";
            story.ten_truyen = "Tuyết Sơn Phi Hổ";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void hiep_khach_hanh_Click(object sender, EventArgs e)
        {
            story.ten = "hiep_khach_hanh";
            story.ten_truyen = "Hiệp Khách Hành";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void viet_nu_kiem_Click(object sender, EventArgs e)
        {
            story.ten = "viet_nu_kiem";
            story.ten_truyen = "Việt Nữ Kiếm";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void phi_ho_ngoai_truyen_Click(object sender, EventArgs e)
        {
            story.ten = "phi_ho_ngoai_truyen";
            story.ten_truyen = "Phi Hổ Ngoại Truyện";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void thu_kiem_an_cuu_luc_Click(object sender, EventArgs e)
        {
            story.ten = "thu_kiem_an_cuu_luc";
            story.ten_truyen = "Thư Kiếm Ân Cừu Lục";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void co_gai_do_long_Click(object sender, EventArgs e)
        {
            story.ten = "co_gai_do_long";
            story.ten_truyen = "Cô Gái Đồ Long";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void bich_huyet_kiem_Click(object sender, EventArgs e)
        {
            story.ten = "bich_huyet_kiem";
            story.ten_truyen = "Bích Huyết Kiếm";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void song_nu_hiep_hong_y_Click(object sender, EventArgs e)
        {
            story.ten = "song_nu_hiep_hong_y";
            story.ten_truyen = "Song Nữ Hiệp Hồng Y";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void hac_thanh_than_tieu_Click(object sender, EventArgs e)
        {
            story.ten = "truyen_hac_thanh_than";
            story.ten_truyen = "Hắc Thánh Thần Tiêu";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void bach_ma_kieu_tay_phong_Click(object sender, EventArgs e)
        {
            story.ten = "bach_ma_khieu_tay_phong";
            story.ten_truyen = "Bạch Mã Khiếu Tây Phong";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void luc_mach_than_kiem_Click(object sender, EventArgs e)
        {
            story.ten = "luc_mach_than_kiem";
            story.ten_truyen = "Lục Mạch Thần Kiếm";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void vo_lam_ngu_ba_Click(object sender, EventArgs e)
        {
            story.ten = "vo_lam_ngu_ba";
            story.ten_truyen = "Võ Lâm Ngũ Bá";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void uyen_uong_dao_Click(object sender, EventArgs e)
        {
            story.ten = "uyen_uong_dao";
            story.ten_truyen = "Uyên Ương Đao";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void lien_thanh_quyet_Click(object sender, EventArgs e)
        {
            story.ten = "lien_thanh_quyet";
            story.ten_truyen = "Liên Thanh Quyết";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

    }
}
