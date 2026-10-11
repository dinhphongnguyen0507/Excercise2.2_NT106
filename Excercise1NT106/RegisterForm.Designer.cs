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
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
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
            txtTenDangNhap.Location = new Point(202, 28);
            txtTenDangNhap.MaxLength = 20;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "  3-20 ký tự";
            txtTenDangNhap.Size = new Size(288, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(202, 96);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "  Tối thiểu 8 ký tự";
            txtMatKhau.Size = new Size(288, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(202, 158);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PlaceholderText = "  Nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(288, 27);
            txtXacNhanMatKhau.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(202, 224);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "  Nguyễn Văn A";
            txtHoTen.Size = new Size(288, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  ten@mien.com";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 295);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 10;
            label5.Text = "Email (không bắt buộc)";
            label5.Click += label5_Click;
            // 
            // BtnDangKy
            // 
            BtnDangKy.BackColor = Color.FromArgb(0, 192, 192);
            BtnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDangKy.ForeColor = SystemColors.ControlLightLight;
            BtnDangKy.Location = new Point(119, 373);
            BtnDangKy.Name = "BtnDangKy";
            BtnDangKy.Size = new Size(176, 72);
            BtnDangKy.TabIndex = 5;
            BtnDangKy.Text = "Đăng Ký";
            BtnDangKy.UseVisualStyleBackColor = false;
            BtnDangKy.Click += BtnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(328, 373);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(162, 72);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblLoiTen
            // 
            lblLoiTen.AutoSize = true;
            lblLoiTen.ForeColor = Color.Red;
            lblLoiTen.Location = new Point(202, 58);
            lblLoiTen.Name = "lblLoiTen";
            lblLoiTen.Size = new Size(0, 20);
            lblLoiTen.TabIndex = 11;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(202, 126);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 20);
            lblLoiMatKhau.TabIndex = 12;
            lblLoiMatKhau.Click += lblLoiMatKhau_Click;
            // 
            // lblLoiXacNhan
            // 
            lblLoiXacNhan.AutoSize = true;
            lblLoiXacNhan.ForeColor = Color.Red;
            lblLoiXacNhan.Location = new Point(202, 188);
            lblLoiXacNhan.Name = "lblLoiXacNhan";
            lblLoiXacNhan.Size = new Size(0, 20);
            lblLoiXacNhan.TabIndex = 13;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.AutoSize = true;
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(202, 254);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(0, 20);
            lblLoiHoTen.TabIndex = 14;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.AutoSize = true;
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(202, 325);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(0, 20);
            lblLoiEmail.TabIndex = 15;
            // 
            // RegisterForm
            // 
            AcceptButton = BtnDangKy;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new Size(502, 513);
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
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Đăng Ký Tài Khoản";
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