using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Excercise1NT106
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void XoaTatCaLoi()
        {
            lblLoiTen.Text = "";
            lblLoiMatKhau.Text = "";
            lblLoiXacNhan.Text = "";
            lblLoiHoTen.Text = "";
            lblLoiEmail.Text = "";
        }
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            XoaTatCaLoi();

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhan = txtXacNhanMatKhau.Text;
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();

            bool hopLe = true;
            //tenDangNhap
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoiTen.Text = "Chưa nhập tên đăng nhập.";
                hopLe = false;
            }
            else if (tenDangNhap.Length < 3 || tenDangNhap.Length > 20)
            {
                lblLoiTen.Text = "Tên đăng nhập phải dài từ 3 đến 20 ký tự.";
                hopLe = false;
            }
            else if (!Regex.IsMatch(tenDangNhap, @"^[A-Za-z0-9_]+$"))
            {
                lblLoiTen.Text = "Chỉ dùng chữ cái, số và dấu gạch dưới (_).";
                hopLe = false;
            }
            //matkhau
            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoiMatKhau.Text = "Chưa nhập mật khẩu.";
                hopLe = false;
            }
            else if (matKhau.Length < 8)
            {
                lblLoiMatKhau.Text = "Mật khẩu phải có ít nhất 8 ký tự.";
                hopLe = false;
            }
            else if (!Regex.IsMatch(matKhau, @"[A-Za-z]") || !Regex.IsMatch(matKhau, @"[0-9]"))
            {
                lblLoiMatKhau.Text = "Mật khẩu phải chứa cả chữ và số.";
                hopLe = false;
            }
            //xacnhan matkhau
            if (string.IsNullOrEmpty(xacNhan))
            {
                lblLoiXacNhan.Text = "Vui lòng xác nhận mật khẩu.";
                hopLe = false;
            }
            else if (matKhau != xacNhan)
            {
                lblLoiXacNhan.Text = "Hai ô mật khẩu không giống nhau.";
                txtXacNhanMatKhau.Clear();
                hopLe = false;
            }
            //kiem tra ho ten
            if (string.IsNullOrEmpty(hoTen))
            {
                lblLoiHoTen.Text = "Chưa nhập họ và tên.";
                hopLe = false;
            }
            else if (hoTen.Length < 2 || hoTen.Length > 50)
            {
                lblLoiHoTen.Text = "Họ và tên phải từ 2 đến 50 ký tự.";
                hopLe = false;
            }
            //email
            if (!string.IsNullOrEmpty(email))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    lblLoiEmail.Text = "Email phải có định dạng đúng (ví dụ: ten@mien.com).";
                    hopLe = false;
                }
            }
         


        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
