namespace Phan2
{
    partial class Checking
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
            CheckingDepositbtn = new Button();
            CheckingDTbtn = new Button();
            SavingDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SavingDGV).BeginInit();
            SuspendLayout();
            // 
            // CheckingDepositbtn
            // 
            CheckingDepositbtn.Location = new Point(54, 36);
            CheckingDepositbtn.Name = "CheckingDepositbtn";
            CheckingDepositbtn.Size = new Size(75, 23);
            CheckingDepositbtn.TabIndex = 0;
            CheckingDepositbtn.Text = "Deposit";
            CheckingDepositbtn.UseVisualStyleBackColor = true;
            // 
            // CheckingDTbtn
            // 
            CheckingDTbtn.Location = new Point(634, 36);
            CheckingDTbtn.Name = "CheckingDTbtn";
            CheckingDTbtn.Size = new Size(120, 23);
            CheckingDTbtn.TabIndex = 1;
            CheckingDTbtn.Text = "Display Transaction";
            CheckingDTbtn.UseVisualStyleBackColor = true;
            // 
            // SavingDGV
            // 
            SavingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SavingDGV.Location = new Point(24, 93);
            SavingDGV.Name = "SavingDGV";
            SavingDGV.Size = new Size(740, 330);
            SavingDGV.TabIndex = 2;
            // 
            // Checking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SavingDGV);
            Controls.Add(CheckingDTbtn);
            Controls.Add(CheckingDepositbtn);
            Name = "Checking";
            Text = "Checking";
            ((System.ComponentModel.ISupportInitialize)SavingDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CheckingDepositbtn;
        private Button CheckingDTbtn;
        private DataGridView SavingDGV;
    }
}