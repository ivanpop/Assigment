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
            this.tradePartnersLbl = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gdpBox = new System.Windows.Forms.TextBox();
            this.inflationBox = new System.Windows.Forms.TextBox();
            this.tradeBalanceBox = new System.Windows.Forms.TextBox();
            this.hdiBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tradePAddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(13, 247);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(106, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // gdpLbl
            // 
            this.gdpLbl.AutoSize = true;
            this.gdpLbl.Location = new System.Drawing.Point(131, 16);
            this.gdpLbl.Name = "gdpLbl";
            this.gdpLbl.Size = new System.Drawing.Size(68, 13);
            this.gdpLbl.TabIndex = 2;
            this.gdpLbl.Text = "GDP growth:";
            // 
            // inflationLbl
            // 
            this.inflationLbl.AutoSize = true;
            this.inflationLbl.Location = new System.Drawing.Point(131, 42);
            this.inflationLbl.Name = "inflationLbl";
            this.inflationLbl.Size = new System.Drawing.Size(47, 13);
            this.inflationLbl.TabIndex = 3;
            this.inflationLbl.Text = "Inflation:";
            // 
            // tradeBalanceLbl
            // 
            this.tradeBalanceLbl.AutoSize = true;
            this.tradeBalanceLbl.Location = new System.Drawing.Point(131, 68);
            this.tradeBalanceLbl.Name = "tradeBalanceLbl";
            this.tradeBalanceLbl.Size = new System.Drawing.Size(79, 13);
            this.tradeBalanceLbl.TabIndex = 4;
            this.tradeBalanceLbl.Text = "Trade balance:";
            // 
            // hdiRankLbl
            // 
            this.hdiRankLbl.AutoSize = true;
            this.hdiRankLbl.Location = new System.Drawing.Point(131, 94);
            this.hdiRankLbl.Name = "hdiRankLbl";
            this.hdiRankLbl.Size = new System.Drawing.Size(53, 13);
            this.hdiRankLbl.TabIndex = 5;
            this.hdiRankLbl.Text = "HDI rank:";
            // 
            // tradePartnersLbl
            // 
            this.tradePartnersLbl.AutoSize = true;
            this.tradePartnersLbl.Location = new System.Drawing.Point(131, 118);
            this.tradePartnersLbl.Name = "tradePartnersLbl";
            this.tradePartnersLbl.Size = new System.Drawing.Size(79, 13);
            this.tradePartnersLbl.TabIndex = 10;
            this.tradePartnersLbl.Text = "Trade partners:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(236, 118);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(90, 69);
            this.listBox2.TabIndex = 11;
            // 
            // gdpBox
            // 
            this.gdpBox.Location = new System.Drawing.Point(284, 14);
            this.gdpBox.Name = "gdpBox";
            this.gdpBox.Size = new System.Drawing.Size(42, 20);
            this.gdpBox.TabIndex = 12;
            // 
            // inflationBox
            // 
            this.inflationBox.Location = new System.Drawing.Point(284, 40);
            this.inflationBox.Name = "inflationBox";
            this.inflationBox.Size = new System.Drawing.Size(42, 20);
            this.inflationBox.TabIndex = 13;
            // 
            // tradeBalanceBox
            // 
            this.tradeBalanceBox.Location = new System.Drawing.Point(284, 66);
            this.tradeBalanceBox.Name = "tradeBalanceBox";
            this.tradeBalanceBox.Size = new System.Drawing.Size(42, 20);
            this.tradeBalanceBox.TabIndex = 14;
            // 
            // hdiBox
            // 
            this.hdiBox.Location = new System.Drawing.Point(285, 92);
            this.hdiBox.Name = "hdiBox";
            this.hdiBox.Size = new System.Drawing.Size(41, 20);
            this.hdiBox.TabIndex = 15;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(236, 193);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 23);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tradePAddBtn
            // 
            this.tradePAddBtn.Location = new System.Drawing.Point(9, 19);
            this.tradePAddBtn.Name = "tradePAddBtn";
            this.tradePAddBtn.Size = new System.Drawing.Size(75, 23);
            this.tradePAddBtn.TabIndex = 18;
            this.tradePAddBtn.Text = "Add new";
            this.tradePAddBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Remove selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tradePAddBtn);
            this.groupBox1.Location = new System.Drawing.Point(126, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit trade partners";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 218);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add Country";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 312);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.hdiBox);
            this.Controls.Add(this.tradeBalanceBox);
            this.Controls.Add(this.inflationBox);
            this.Controls.Add(this.gdpBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.tradePartnersLbl);
            this.Controls.Add(this.hdiRankLbl);
            this.Controls.Add(this.tradeBalanceLbl);
            this.Controls.Add(this.inflationLbl);
            this.Controls.Add(this.gdpLbl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label tradePartnersLbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox gdpBox;
        private System.Windows.Forms.TextBox inflationBox;
        private System.Windows.Forms.TextBox tradeBalanceBox;
        private System.Windows.Forms.TextBox hdiBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button tradePAddBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;

    }
}

