namespace Excercise1NT106
{
    partial class MainForm
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
            namecheckLb = new Label();
            tenDnlb = new Label();
            emailLb = new Label();
            lastcheckedLb = new Label();
            dangxuatBtn = new Button();
            SuspendLayout();
            // 
            // namecheckLb
            // 
            namecheckLb.AutoSize = true;
            namecheckLb.ForeColor = Color.Teal;
            namecheckLb.Location = new Point(25, 26);
            namecheckLb.Name = "namecheckLb";
            namecheckLb.Size = new Size(96, 25);
            namecheckLb.TabIndex = 0;
            namecheckLb.Text = "XIN CHÀO";
            // 
            // tenDnlb
            // 
            tenDnlb.AutoSize = true;
            tenDnlb.Location = new Point(25, 89);
            tenDnlb.Name = "tenDnlb";
            tenDnlb.Size = new Size(133, 25);
            tenDnlb.TabIndex = 1;
            tenDnlb.Text = "Tên đăng nhập:";
            // 
            // emailLb
            // 
            emailLb.AutoSize = true;
            emailLb.Location = new Point(25, 152);
            emailLb.Name = "emailLb";
            emailLb.Size = new Size(58, 25);
            emailLb.TabIndex = 2;
            emailLb.Text = "Email:";
            // 
            // lastcheckedLb
            // 
            lastcheckedLb.AutoSize = true;
            lastcheckedLb.Location = new Point(25, 213);
            lastcheckedLb.Name = "lastcheckedLb";
            lastcheckedLb.Size = new Size(209, 25);
            lastcheckedLb.TabIndex = 3;
            lastcheckedLb.Text = "Lần đăng nhập gần nhất:";
            // 
            // dangxuatBtn
            // 
            dangxuatBtn.BackColor = SystemColors.ScrollBar;
            dangxuatBtn.FlatStyle = FlatStyle.Flat;
            dangxuatBtn.Location = new Point(502, 357);
            dangxuatBtn.Name = "dangxuatBtn";
            dangxuatBtn.Size = new Size(175, 42);
            dangxuatBtn.TabIndex = 4;
            dangxuatBtn.Text = "Đăng xuất";
            dangxuatBtn.UseVisualStyleBackColor = false;
            dangxuatBtn.Click += dangxuatBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dangxuatBtn);
            Controls.Add(lastcheckedLb);
            Controls.Add(emailLb);
            Controls.Add(tenDnlb);
            Controls.Add(namecheckLb);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namecheckLb;
        private Label tenDnlb;
        private Label emailLb;
        private Label lastcheckedLb;
        private Button dangxuatBtn;
    }
}