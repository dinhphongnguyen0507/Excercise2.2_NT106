namespace Excercise1NT106
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tenDnTxt = new TextBox();
            matkhauTxt = new TextBox();
            lblThongbaoloi = new Label();
            rememberBox = new CheckBox();
            dangnhapBtn = new Button();
            thoatBtn = new Button();
            dangkyLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 244);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // tenDnTxt
            // 
            tenDnTxt.Location = new Point(146, 12);
            tenDnTxt.Name = "tenDnTxt";
            tenDnTxt.Size = new Size(284, 26);
            tenDnTxt.TabIndex = 3;
            tenDnTxt.TextChanged += tenDnTxt_TextChanged;
            // 
            // matkhauTxt
            // 
            matkhauTxt.Location = new Point(146, 69);
            matkhauTxt.Name = "matkhauTxt";
            matkhauTxt.PasswordChar = '*';
            matkhauTxt.Size = new Size(284, 26);
            matkhauTxt.TabIndex = 4;
            matkhauTxt.TextChanged += matkhauTxt_TextChanged;
            // 
            // lblThongbaoloi
            // 
            lblThongbaoloi.ForeColor = Color.Red;
            lblThongbaoloi.Location = new Point(146, 95);
            lblThongbaoloi.Name = "lblThongbaoloi";
            lblThongbaoloi.Size = new Size(284, 17);
            lblThongbaoloi.TabIndex = 5;
            lblThongbaoloi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            // 
            // rememberBox
            // 
            rememberBox.AutoSize = true;
            rememberBox.Location = new Point(146, 136);
            rememberBox.Name = "rememberBox";
            rememberBox.Size = new Size(199, 24);
            rememberBox.TabIndex = 6;
            rememberBox.Text = "ghi nhớ tên đăng nhập";
            rememberBox.UseVisualStyleBackColor = true;
            rememberBox.CheckedChanged += rememberBox_CheckedChanged;
            // 
            // dangnhapBtn
            // 
            dangnhapBtn.BackColor = Color.FromArgb(0, 192, 192);
            dangnhapBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dangnhapBtn.ForeColor = SystemColors.ButtonHighlight;
            dangnhapBtn.Location = new Point(146, 196);
            dangnhapBtn.Name = "dangnhapBtn";
            dangnhapBtn.Size = new Size(130, 49);
            dangnhapBtn.TabIndex = 7;
            dangnhapBtn.Text = "Đăng Nhập";
            dangnhapBtn.UseVisualStyleBackColor = false;
            dangnhapBtn.Click += dangnhapBtn_Click;
            // 
            // thoatBtn
            // 
            thoatBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thoatBtn.Location = new Point(300, 196);
            thoatBtn.Name = "thoatBtn";
            thoatBtn.Size = new Size(130, 49);
            thoatBtn.TabIndex = 8;
            thoatBtn.Text = "Thoát";
            thoatBtn.UseVisualStyleBackColor = true;
            thoatBtn.Click += thoatBtn_Click;
            // 
            // dangkyLink
            // 
            dangkyLink.AutoSize = true;
            dangkyLink.Location = new Point(146, 264);
            dangkyLink.Name = "dangkyLink";
            dangkyLink.Size = new Size(217, 20);
            dangkyLink.TabIndex = 9;
            dangkyLink.TabStop = true;
            dangkyLink.Text = "Chưa có tài khoản? Đăng ký";
            dangkyLink.LinkClicked += dangkyLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 293);
            Controls.Add(dangkyLink);
            Controls.Add(thoatBtn);
            Controls.Add(dangnhapBtn);
            Controls.Add(rememberBox);
            Controls.Add(lblThongbaoloi);
            Controls.Add(matkhauTxt);
            Controls.Add(tenDnTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tenDnTxt;
        private TextBox matkhauTxt;
        private Label lblThongbaoloi;
        private CheckBox rememberBox;
        private Button dangnhapBtn;
        private Button thoatBtn;
        private LinkLabel dangkyLink;
    }
}
