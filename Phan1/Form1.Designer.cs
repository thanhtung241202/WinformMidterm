namespace Phan1
{
    partial class Form1
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
            btnExit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            txtDayOfBirth = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            lbEmail = new Label();
            lbDayOfBirth = new Label();
            lbName = new Label();
            lbID = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(344, 187);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 21;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(182, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(465, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtDayOfBirth
            // 
            txtDayOfBirth.Location = new Point(77, 83);
            txtDayOfBirth.Name = "txtDayOfBirth";
            txtDayOfBirth.Size = new Size(465, 23);
            txtDayOfBirth.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(465, 23);
            txtName.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(77, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(465, 23);
            txtID.TabIndex = 15;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(6, 129);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 14;
            lbEmail.Text = "Email";
            // 
            // lbDayOfBirth
            // 
            lbDayOfBirth.AutoSize = true;
            lbDayOfBirth.Location = new Point(6, 91);
            lbDayOfBirth.Name = "lbDayOfBirth";
            lbDayOfBirth.Size = new Size(60, 15);
            lbDayOfBirth.TabIndex = 13;
            lbDayOfBirth.Text = "Ngày sinh";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 53);
            lbName.Name = "lbName";
            lbName.Size = new Size(43, 15);
            lbName.TabIndex = 12;
            lbName.Text = "Họ tên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(6, 15);
            lbID.Name = "lbID";
            lbID.Size = new Size(39, 15);
            lbID.TabIndex = 11;
            lbID.Text = "Mã số";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 150);
            dataGridView1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtDayOfBirth);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lbEmail);
            Controls.Add(lbDayOfBirth);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtEmail;
        private TextBox txtDayOfBirth;
        private TextBox txtName;
        private TextBox txtID;
        private Label lbEmail;
        private Label lbDayOfBirth;
        private Label lbName;
        private Label lbID;
        private DataGridView dataGridView1;
    }
}
