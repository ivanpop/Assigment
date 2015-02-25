namespace AssignmentGUI
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.gdpLbl = new System.Windows.Forms.Label();
            this.inflationLbl = new System.Windows.Forms.Label();
            this.tradeBalanceLbl = new System.Windows.Forms.Label();
            this.hdiRankLbl = new System.Windows.Forms.Label();
            this.gdpSelected = new System.Windows.Forms.Label();
            this.inflationSelected = new System.Windows.Forms.Label();
            this.tradeSelected = new System.Windows.Forms.Label();
            this.hdiSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(140, 13);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // gdpLbl
            // 
            this.gdpLbl.AutoSize = true;
            this.gdpLbl.Location = new System.Drawing.Point(11, 116);
            this.gdpLbl.Name = "gdpLbl";
            this.gdpLbl.Size = new System.Drawing.Size(67, 13);
            this.gdpLbl.TabIndex = 2;
            this.gdpLbl.Text = "GDP Growth";
            // 
            // inflationLbl
            // 
            this.inflationLbl.AutoSize = true;
            this.inflationLbl.Location = new System.Drawing.Point(93, 116);
            this.inflationLbl.Name = "inflationLbl";
            this.inflationLbl.Size = new System.Drawing.Size(44, 13);
            this.inflationLbl.TabIndex = 3;
            this.inflationLbl.Text = "Inflation";
            // 
            // tradeBalanceLbl
            // 
            this.tradeBalanceLbl.AutoSize = true;
            this.tradeBalanceLbl.Location = new System.Drawing.Point(154, 116);
            this.tradeBalanceLbl.Name = "tradeBalanceLbl";
            this.tradeBalanceLbl.Size = new System.Drawing.Size(77, 13);
            this.tradeBalanceLbl.TabIndex = 4;
            this.tradeBalanceLbl.Text = "Trade Balance";
            // 
            // hdiRankLbl
            // 
            this.hdiRankLbl.AutoSize = true;
            this.hdiRankLbl.Location = new System.Drawing.Point(248, 116);
            this.hdiRankLbl.Name = "hdiRankLbl";
            this.hdiRankLbl.Size = new System.Drawing.Size(55, 13);
            this.hdiRankLbl.TabIndex = 5;
            this.hdiRankLbl.Text = "HDI Rank";
            // 
            // gdpSelected
            // 
            this.gdpSelected.AutoSize = true;
            this.gdpSelected.Location = new System.Drawing.Point(12, 144);
            this.gdpSelected.Name = "gdpSelected";
            this.gdpSelected.Size = new System.Drawing.Size(35, 13);
            this.gdpSelected.TabIndex = 9;
            this.gdpSelected.Text = "label5";
            // 
            // inflationSelected
            // 
            this.inflationSelected.AutoSize = true;
            this.inflationSelected.Location = new System.Drawing.Point(93, 144);
            this.inflationSelected.Name = "inflationSelected";
            this.inflationSelected.Size = new System.Drawing.Size(35, 13);
            this.inflationSelected.TabIndex = 8;
            this.inflationSelected.Text = "label6";
            // 
            // tradeSelected
            // 
            this.tradeSelected.AutoSize = true;
            this.tradeSelected.Location = new System.Drawing.Point(154, 144);
            this.tradeSelected.Name = "tradeSelected";
            this.tradeSelected.Size = new System.Drawing.Size(35, 13);
            this.tradeSelected.TabIndex = 7;
            this.tradeSelected.Text = "label7";
            // 
            // hdiSelected
            // 
            this.hdiSelected.AutoSize = true;
            this.hdiSelected.Location = new System.Drawing.Point(248, 144);
            this.hdiSelected.Name = "hdiSelected";
            this.hdiSelected.Size = new System.Drawing.Size(35, 13);
            this.hdiSelected.TabIndex = 6;
            this.hdiSelected.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.gdpSelected);
            this.Controls.Add(this.inflationSelected);
            this.Controls.Add(this.tradeSelected);
            this.Controls.Add(this.hdiSelected);
            this.Controls.Add(this.hdiRankLbl);
            this.Controls.Add(this.tradeBalanceLbl);
            this.Controls.Add(this.inflationLbl);
            this.Controls.Add(this.gdpLbl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label gdpLbl;
        private System.Windows.Forms.Label inflationLbl;
        private System.Windows.Forms.Label tradeBalanceLbl;
        private System.Windows.Forms.Label hdiRankLbl;
        private System.Windows.Forms.Label gdpSelected;
        private System.Windows.Forms.Label inflationSelected;
        private System.Windows.Forms.Label tradeSelected;
        private System.Windows.Forms.Label hdiSelected;

    }
}

