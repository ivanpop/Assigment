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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gdpBox = new System.Windows.Forms.TextBox();
            this.inflationBox = new System.Windows.Forms.TextBox();
            this.tradeBalanceBox = new System.Windows.Forms.TextBox();
            this.hdiBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tradePAddBtn = new System.Windows.Forms.Button();
            this.tradePRemBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.countriesCountTxtLbl = new System.Windows.Forms.Label();
            this.countriesCountLbl = new System.Windows.Forms.Label();
            this.countriesBox = new System.Windows.Forms.GroupBox();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.tradingPartnersBox = new System.Windows.Forms.GroupBox();
            this.partnersCountLblTxt = new System.Windows.Forms.Label();
            this.partnersCountLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.countriesBox.SuspendLayout();
            this.propertiesBox.SuspendLayout();
            this.tradingPartnersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(6, 266);
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
            this.gdpLbl.Location = new System.Drawing.Point(6, 27);
            this.gdpLbl.Name = "gdpLbl";
            this.gdpLbl.Size = new System.Drawing.Size(68, 13);
            this.gdpLbl.TabIndex = 2;
            this.gdpLbl.Text = "GDP growth:";
            // 
            // inflationLbl
            // 
            this.inflationLbl.AutoSize = true;
            this.inflationLbl.Location = new System.Drawing.Point(6, 55);
            this.inflationLbl.Name = "inflationLbl";
            this.inflationLbl.Size = new System.Drawing.Size(47, 13);
            this.inflationLbl.TabIndex = 3;
            this.inflationLbl.Text = "Inflation:";
            // 
            // tradeBalanceLbl
            // 
            this.tradeBalanceLbl.AutoSize = true;
            this.tradeBalanceLbl.Location = new System.Drawing.Point(6, 83);
            this.tradeBalanceLbl.Name = "tradeBalanceLbl";
            this.tradeBalanceLbl.Size = new System.Drawing.Size(79, 13);
            this.tradeBalanceLbl.TabIndex = 4;
            this.tradeBalanceLbl.Text = "Trade balance:";
            // 
            // hdiRankLbl
            // 
            this.hdiRankLbl.AutoSize = true;
            this.hdiRankLbl.Location = new System.Drawing.Point(6, 111);
            this.hdiRankLbl.Name = "hdiRankLbl";
            this.hdiRankLbl.Size = new System.Drawing.Size(53, 13);
            this.hdiRankLbl.TabIndex = 5;
            this.hdiRankLbl.Text = "HDI rank:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(106, 199);
            this.listBox2.TabIndex = 11;
            // 
            // gdpBox
            // 
            this.gdpBox.Location = new System.Drawing.Point(112, 24);
            this.gdpBox.Name = "gdpBox";
            this.gdpBox.Size = new System.Drawing.Size(42, 20);
            this.gdpBox.TabIndex = 12;
            // 
            // inflationBox
            // 
            this.inflationBox.Location = new System.Drawing.Point(112, 52);
            this.inflationBox.Name = "inflationBox";
            this.inflationBox.Size = new System.Drawing.Size(42, 20);
            this.inflationBox.TabIndex = 13;
            // 
            // tradeBalanceBox
            // 
            this.tradeBalanceBox.Location = new System.Drawing.Point(112, 80);
            this.tradeBalanceBox.Name = "tradeBalanceBox";
            this.tradeBalanceBox.Size = new System.Drawing.Size(42, 20);
            this.tradeBalanceBox.TabIndex = 14;
            // 
            // hdiBox
            // 
            this.hdiBox.Location = new System.Drawing.Point(113, 108);
            this.hdiBox.Name = "hdiBox";
            this.hdiBox.Size = new System.Drawing.Size(41, 20);
            this.hdiBox.TabIndex = 15;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(36, 149);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 23);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tradePAddBtn
            // 
            this.tradePAddBtn.Location = new System.Drawing.Point(6, 237);
            this.tradePAddBtn.Name = "tradePAddBtn";
            this.tradePAddBtn.Size = new System.Drawing.Size(106, 23);
            this.tradePAddBtn.TabIndex = 18;
            this.tradePAddBtn.Text = "Add partner";
            this.tradePAddBtn.UseVisualStyleBackColor = true;
            this.tradePAddBtn.Click += new System.EventHandler(this.tradePAddBtn_Click);
            // 
            // tradePRemBtn
            // 
            this.tradePRemBtn.Location = new System.Drawing.Point(6, 266);
            this.tradePRemBtn.Name = "tradePRemBtn";
            this.tradePRemBtn.Size = new System.Drawing.Size(106, 23);
            this.tradePRemBtn.TabIndex = 19;
            this.tradePRemBtn.Text = "Remove selected";
            this.tradePRemBtn.UseVisualStyleBackColor = true;
            this.tradePRemBtn.Click += new System.EventHandler(this.tradePRemBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(6, 237);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add country";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // countriesCountTxtLbl
            // 
            this.countriesCountTxtLbl.AutoSize = true;
            this.countriesCountTxtLbl.Location = new System.Drawing.Point(3, 221);
            this.countriesCountTxtLbl.Name = "countriesCountTxtLbl";
            this.countriesCountTxtLbl.Size = new System.Drawing.Size(42, 13);
            this.countriesCountTxtLbl.TabIndex = 19;
            this.countriesCountTxtLbl.Text = "Entires:";
            // 
            // countriesCountLbl
            // 
            this.countriesCountLbl.AutoSize = true;
            this.countriesCountLbl.Location = new System.Drawing.Point(51, 221);
            this.countriesCountLbl.Name = "countriesCountLbl";
            this.countriesCountLbl.Size = new System.Drawing.Size(13, 13);
            this.countriesCountLbl.TabIndex = 20;
            this.countriesCountLbl.Text = "0";
            // 
            // countriesBox
            // 
            this.countriesBox.Controls.Add(this.listBox1);
            this.countriesBox.Controls.Add(this.addBtn);
            this.countriesBox.Controls.Add(this.countriesCountLbl);
            this.countriesBox.Controls.Add(this.countriesCountTxtLbl);
            this.countriesBox.Controls.Add(this.removeBtn);
            this.countriesBox.Location = new System.Drawing.Point(7, 6);
            this.countriesBox.Name = "countriesBox";
            this.countriesBox.Size = new System.Drawing.Size(119, 301);
            this.countriesBox.TabIndex = 22;
            this.countriesBox.TabStop = false;
            this.countriesBox.Text = "Countries";
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.gdpLbl);
            this.propertiesBox.Controls.Add(this.inflationLbl);
            this.propertiesBox.Controls.Add(this.SaveBtn);
            this.propertiesBox.Controls.Add(this.tradeBalanceLbl);
            this.propertiesBox.Controls.Add(this.hdiBox);
            this.propertiesBox.Controls.Add(this.hdiRankLbl);
            this.propertiesBox.Controls.Add(this.tradeBalanceBox);
            this.propertiesBox.Controls.Add(this.inflationBox);
            this.propertiesBox.Controls.Add(this.gdpBox);
            this.propertiesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertiesBox.Location = new System.Drawing.Point(256, 6);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(166, 191);
            this.propertiesBox.TabIndex = 23;
            this.propertiesBox.TabStop = false;
            this.propertiesBox.Text = "Properties";
            // 
            // tradingPartnersBox
            // 
            this.tradingPartnersBox.Controls.Add(this.partnersCountLbl);
            this.tradingPartnersBox.Controls.Add(this.partnersCountLblTxt);
            this.tradingPartnersBox.Controls.Add(this.tradePRemBtn);
            this.tradingPartnersBox.Controls.Add(this.listBox2);
            this.tradingPartnersBox.Controls.Add(this.tradePAddBtn);
            this.tradingPartnersBox.Location = new System.Drawing.Point(132, 6);
            this.tradingPartnersBox.Name = "tradingPartnersBox";
            this.tradingPartnersBox.Size = new System.Drawing.Size(118, 295);
            this.tradingPartnersBox.TabIndex = 24;
            this.tradingPartnersBox.TabStop = false;
            this.tradingPartnersBox.Text = "Trading Partners";
            // 
            // partnersCountLblTxt
            // 
            this.partnersCountLblTxt.AutoSize = true;
            this.partnersCountLblTxt.Location = new System.Drawing.Point(6, 221);
            this.partnersCountLblTxt.Name = "partnersCountLblTxt";
            this.partnersCountLblTxt.Size = new System.Drawing.Size(42, 13);
            this.partnersCountLblTxt.TabIndex = 20;
            this.partnersCountLblTxt.Text = "Entires:";
            // 
            // partnersCountLbl
            // 
            this.partnersCountLbl.AutoSize = true;
            this.partnersCountLbl.Location = new System.Drawing.Point(54, 221);
            this.partnersCountLbl.Name = "partnersCountLbl";
            this.partnersCountLbl.Size = new System.Drawing.Size(13, 13);
            this.partnersCountLbl.TabIndex = 25;
            this.partnersCountLbl.Text = "0";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(292, 227);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(90, 40);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tradingPartnersBox);
            this.Controls.Add(this.propertiesBox);
            this.Controls.Add(this.countriesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.countriesBox.ResumeLayout(false);
            this.countriesBox.PerformLayout();
            this.propertiesBox.ResumeLayout(false);
            this.propertiesBox.PerformLayout();
            this.tradingPartnersBox.ResumeLayout(false);
            this.tradingPartnersBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label gdpLbl;
        private System.Windows.Forms.Label inflationLbl;
        private System.Windows.Forms.Label tradeBalanceLbl;
        private System.Windows.Forms.Label hdiRankLbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox gdpBox;
        private System.Windows.Forms.TextBox inflationBox;
        private System.Windows.Forms.TextBox tradeBalanceBox;
        private System.Windows.Forms.TextBox hdiBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button tradePAddBtn;
        private System.Windows.Forms.Button tradePRemBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label countriesCountTxtLbl;
        private System.Windows.Forms.Label countriesCountLbl;
        private System.Windows.Forms.GroupBox countriesBox;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.GroupBox tradingPartnersBox;
        private System.Windows.Forms.Label partnersCountLbl;
        private System.Windows.Forms.Label partnersCountLblTxt;
        private System.Windows.Forms.Button closeBtn;

    }
}

