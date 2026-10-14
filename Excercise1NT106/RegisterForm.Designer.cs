namespace Excercise1NT106
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            BtnDangKy = new Button();
            btnHuy = new Button();
            lblLoiTen = new Label();
            lblLoiMatKhau = new Label();
            lblLoiXacNhan = new Label();
            lblLoiHoTen = new Label();
            lblLoiEmail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 2;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(252, 35);
            txtTenDangNhap.Margin = new Padding(4, 4, 4, 4);
            txtTenDangNhap.MaxLength = 20;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "  3-20 ký tự";
            txtTenDangNhap.Size = new Size(359, 31);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(252, 120);
            txtMatKhau.Margin = new Padding(4, 4, 4, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "  Tối thiểu 8 ký tự";
            txtMatKhau.Size = new Size(359, 31);
            txtMatKhau.TabIndex = 1;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(252, 198);
            txtXacNhanMatKhau.Margin = new Padding(4, 4, 4, 4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PlaceholderText = "  Nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(359, 31);
            txtXacNhanMatKhau.TabIndex = 2;
            txtXacNhanMatKhau.TextChanged += txtXacNhanMatKhau_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(252, 280);
            txtHoTen.Margin = new Padding(4, 4, 4, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "  Nguyễn Văn A";
            txtHoTen.Size = new Size(359, 31);
            txtHoTen.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(252, 369);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  ten@mien.com";
            txtEmail.Size = new Size(359, 31);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 280);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 369);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 10;
            label5.Text = "Email (không bắt buộc)";
            label5.Click += label5_Click;
            // 
            // BtnDangKy
            // 
            BtnDangKy.BackColor = Color.FromArgb(0, 192, 192);
            BtnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDangKy.ForeColor = SystemColors.ControlLightLight;
            BtnDangKy.Location = new Point(149, 466);
            BtnDangKy.Margin = new Padding(4, 4, 4, 4);
            BtnDangKy.Name = "BtnDangKy";
            BtnDangKy.Size = new Size(220, 90);
            BtnDangKy.TabIndex = 5;
            BtnDangKy.Text = "Đăng Ký";
            BtnDangKy.UseVisualStyleBackColor = false;
            BtnDangKy.Click += BtnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(410, 466);
            btnHuy.Margin = new Padding(4, 4, 4, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(202, 90);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblLoiTen
            // 
            lblLoiTen.AutoSize = true;
            lblLoiTen.ForeColor = Color.Red;
            lblLoiTen.Location = new Point(252, 72);
            lblLoiTen.Margin = new Padding(4, 0, 4, 0);
            lblLoiTen.Name = "lblLoiTen";
            lblLoiTen.Size = new Size(0, 25);
            lblLoiTen.TabIndex = 11;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(252, 158);
            lblLoiMatKhau.Margin = new Padding(4, 0, 4, 0);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 25);
            lblLoiMatKhau.TabIndex = 12;
            lblLoiMatKhau.Click += lblLoiMatKhau_Click;
            // 
            // lblLoiXacNhan
            // 
            lblLoiXacNhan.AutoSize = true;
            lblLoiXacNhan.ForeColor = Color.Red;
            lblLoiXacNhan.Location = new Point(252, 235);
            lblLoiXacNhan.Margin = new Padding(4, 0, 4, 0);
            lblLoiXacNhan.Name = "lblLoiXacNhan";
            lblLoiXacNhan.Size = new Size(0, 25);
            lblLoiXacNhan.TabIndex = 13;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.AutoSize = true;
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(252, 318);
            lblLoiHoTen.Margin = new Padding(4, 0, 4, 0);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(0, 25);
            lblLoiHoTen.TabIndex = 14;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.AutoSize = true;
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(252, 406);
            lblLoiEmail.Margin = new Padding(4, 0, 4, 0);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(0, 25);
            lblLoiEmail.TabIndex = 15;
            // 
            // RegisterForm
            // 
            AcceptButton = BtnDangKy;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new Size(628, 641);
            Controls.Add(lblLoiEmail);
            Controls.Add(lblLoiHoTen);
            Controls.Add(lblLoiXacNhan);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(lblLoiTen);
            Controls.Add(btnHuy);
            Controls.Add(BtnDangKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Đăng Ký Tài Khoản";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private Button BtnDangKy;
        private Button btnHuy;
        private Label lblLoiTen;
        private Label lblLoiMatKhau;
        private Label lblLoiXacNhan;
        private Label lblLoiHoTen;
        private Label lblLoiEmail;
    }
}