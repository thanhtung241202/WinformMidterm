namespace Phan2
{
    partial class Saving
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
            button1 = new Button();
            SavingSTKlbl = new Label();
            SavingNamelbl = new Label();
            SavingDClbl = new Label();
            SavingSDTlbl = new Label();
            SavingSTKtb = new TextBox();
            SavingNametb = new TextBox();
            SavingAddresstb = new TextBox();
            SavingSDTtb = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(474, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // SavingSTKlbl
            // 
            SavingSTKlbl.AutoSize = true;
            SavingSTKlbl.Location = new Point(38, 58);
            SavingSTKlbl.Name = "SavingSTKlbl";
            SavingSTKlbl.Size = new Size(26, 15);
            SavingSTKlbl.TabIndex = 1;
            SavingSTKlbl.Text = "STK";
            // 
            // SavingNamelbl
            // 
            SavingNamelbl.AutoSize = true;
            SavingNamelbl.Location = new Point(37, 94);
            SavingNamelbl.Name = "SavingNamelbl";
            SavingNamelbl.Size = new Size(39, 15);
            SavingNamelbl.TabIndex = 2;
            SavingNamelbl.Text = "Name";
            // 
            // SavingDClbl
            // 
            SavingDClbl.AutoSize = true;
            SavingDClbl.Location = new Point(37, 129);
            SavingDClbl.Name = "SavingDClbl";
            SavingDClbl.Size = new Size(49, 15);
            SavingDClbl.TabIndex = 3;
            SavingDClbl.Text = "Address";
            // 
            // SavingSDTlbl
            // 
            SavingSDTlbl.AutoSize = true;
            SavingSDTlbl.Location = new Point(37, 165);
            SavingSDTlbl.Name = "SavingSDTlbl";
            SavingSDTlbl.Size = new Size(27, 15);
            SavingSDTlbl.TabIndex = 4;
            SavingSDTlbl.Text = "SĐT";
            // 
            // SavingSTKtb
            // 
            SavingSTKtb.Location = new Point(92, 55);
            SavingSTKtb.Name = "SavingSTKtb";
            SavingSTKtb.Size = new Size(302, 23);
            SavingSTKtb.TabIndex = 5;
            // 
            // SavingNametb
            // 
            SavingNametb.Location = new Point(92, 91);
            SavingNametb.Name = "SavingNametb";
            SavingNametb.Size = new Size(302, 23);
            SavingNametb.TabIndex = 6;
            // 
            // SavingAddresstb
            // 
            SavingAddresstb.Location = new Point(92, 126);
            SavingAddresstb.Name = "SavingAddresstb";
            SavingAddresstb.Size = new Size(302, 23);
            SavingAddresstb.TabIndex = 7;
            // 
            // SavingSDTtb
            // 
            SavingSDTtb.Location = new Point(92, 162);
            SavingSDTtb.Name = "SavingSDTtb";
            SavingSDTtb.Size = new Size(302, 23);
            SavingSDTtb.TabIndex = 8;
            // 
            // Saving
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 273);
            Controls.Add(SavingSDTtb);
            Controls.Add(SavingAddresstb);
            Controls.Add(SavingNametb);
            Controls.Add(SavingSTKtb);
            Controls.Add(SavingSDTlbl);
            Controls.Add(SavingDClbl);
            Controls.Add(SavingNamelbl);
            Controls.Add(SavingSTKlbl);
            Controls.Add(button1);
            Name = "Saving";
            Text = "Saving";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label SavingSTKlbl;
        private Label SavingNamelbl;
        private Label SavingDClbl;
        private Label SavingSDTlbl;
        private TextBox SavingSTKtb;
        private TextBox SavingNametb;
        private TextBox SavingAddresstb;
        private TextBox SavingSDTtb;
    }
}