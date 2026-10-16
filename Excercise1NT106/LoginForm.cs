namespace Excercise1NT106
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dangkyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm hienthi = new RegisterForm();
            this.Hide();
            hienthi.ShowDialog();
            this.Show();
        }

        private async void dangnhapBtn_Click(object sender, EventArgs e)
        {
            lblThongbaoloi.Visible = false;
            string ten = tenDnTxt.Text.Trim();
            string matkhau = matkhauTxt.Text;
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(matkhau))
            {
                lblThongbaoloi.Text = "Vui lòng nhập tên đăng nhập và mật khẩu.";
                lblThongbaoloi.Visible = true;
                return;
            }

            try
            {
                dangnhapBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var user = await DatabaseHelper.LayNguoiDungAsync(ten);
                if (user == null)
                {
                    lblThongbaoloi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    lblThongbaoloi.Visible = true;
                    return;
                }

                bool ok = MatKhau.KiemTra(matkhau, user.Salt, user.MatKhauBam);
                if (!ok)
                {
                    lblThongbaoloi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    lblThongbaoloi.Visible = true;
                    return;
                }

                // thành công -> mở MainForm
                MainForm hienthi = new MainForm();
                this.Hide();
                hienthi.ShowDialog();
                this.Show();
            }
            finally
            {
                dangnhapBtn.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void rememberBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void matkhauTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenDnTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
