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

        private void dangnhapBtn_Click(object sender, EventArgs e)
        {
            MainForm hienthi = new MainForm();
            this.Hide();
            hienthi.ShowDialog();
            this.Show();
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
