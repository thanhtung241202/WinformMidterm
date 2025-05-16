namespace Phan2
{
    partial class LoginFrm
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
            LoginLbl = new Label();
            accountIDLbl = new Label();
            passwordLbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // LoginLbl
            // 
            LoginLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLbl.Location = new Point(77, 74);
            LoginLbl.Name = "LoginLbl";
            LoginLbl.Size = new Size(403, 82);
            LoginLbl.TabIndex = 0;
            LoginLbl.Text = "LOG IN";
            LoginLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accountIDLbl
            // 
            accountIDLbl.AutoSize = true;
            accountIDLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            accountIDLbl.Location = new Point(76, 205);
            accountIDLbl.Name = "accountIDLbl";
            accountIDLbl.Size = new Size(79, 15);
            accountIDLbl.TabIndex = 1;
            accountIDLbl.Text = "ACCOUNT ID";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordLbl.Location = new Point(77, 271);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(73, 15);
            passwordLbl.TabIndex = 2;
            passwordLbl.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(173, 357);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(188, 43);
            loginbtn.TabIndex = 5;
            loginbtn.Text = "LOG IN";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 606);
            Controls.Add(loginbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(passwordLbl);
            Controls.Add(accountIDLbl);
            Controls.Add(LoginLbl);
            Name = "LoginFrm";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLbl;
        private Label accountIDLbl;
        private Label passwordLbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginbtn;
    }
}
