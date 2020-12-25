namespace tradingapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_acct_val = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_risk_percent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_risk_amt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_share_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sq = new System.Windows.Forms.TextBox();
            this.tb_lev_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_lev_mult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_trade_amt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_total_price = new System.Windows.Forms.TextBox();
            this.label_price_acc_percentage = new System.Windows.Forms.Label();
            this.tb_manual_invest = new System.Windows.Forms.TextBox();
            this.cb_manual_invest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Value";
            // 
            // tb_acct_val
            // 
            this.tb_acct_val.Location = new System.Drawing.Point(109, 32);
            this.tb_acct_val.Name = "tb_acct_val";
            this.tb_acct_val.Size = new System.Drawing.Size(100, 20);
            this.tb_acct_val.TabIndex = 1;
            this.tb_acct_val.TextChanged += new System.EventHandler(this.tb_acct_val_TextChanged);
            this.tb_acct_val.Click += new System.EventHandler(this.tb_acct_val_Click);
            this.tb_acct_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Risk (%)";
            // 
            // tb_risk_percent
            // 
            this.tb_risk_percent.Location = new System.Drawing.Point(109, 72);
            this.tb_risk_percent.Name = "tb_risk_percent";
            this.tb_risk_percent.Size = new System.Drawing.Size(52, 20);
            this.tb_risk_percent.TabIndex = 3;
            this.tb_risk_percent.TextChanged += new System.EventHandler(this.tb_risk_percent_TextChanged);
            this.tb_risk_percent.Click += new System.EventHandler(this.tb_risk_percent_Click);
            this.tb_risk_percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Risked Amt";
            // 
            // tb_risk_amt
            // 
            this.tb_risk_amt.Location = new System.Drawing.Point(243, 72);
            this.tb_risk_amt.Name = "tb_risk_amt";
            this.tb_risk_amt.ReadOnly = true;
            this.tb_risk_amt.Size = new System.Drawing.Size(100, 20);
            this.tb_risk_amt.TabIndex = 5;
            this.tb_risk_amt.TextChanged += new System.EventHandler(this.tb_risk_amt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Share price";
            // 
            // tb_share_price
            // 
            this.tb_share_price.Location = new System.Drawing.Point(109, 120);
            this.tb_share_price.Name = "tb_share_price";
            this.tb_share_price.Size = new System.Drawing.Size(100, 20);
            this.tb_share_price.TabIndex = 7;
            this.tb_share_price.TextChanged += new System.EventHandler(this.tb_share_price_TextChanged);
            this.tb_share_price.Click += new System.EventHandler(this.tb_share_price_TextChanged);
            this.tb_share_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop Loss";
            // 
            // tb_sl
            // 
            this.tb_sl.Location = new System.Drawing.Point(109, 205);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(100, 20);
            this.tb_sl.TabIndex = 9;
            this.tb_sl.TextChanged += new System.EventHandler(this.tb_sl_TextChanged);
            this.tb_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Leverage price";
            // 
            // tb_sq
            // 
            this.tb_sq.Location = new System.Drawing.Point(109, 254);
            this.tb_sq.Name = "tb_sq";
            this.tb_sq.ReadOnly = true;
            this.tb_sq.Size = new System.Drawing.Size(100, 20);
            this.tb_sq.TabIndex = 11;
            // 
            // tb_lev_price
            // 
            this.tb_lev_price.Location = new System.Drawing.Point(109, 158);
            this.tb_lev_price.Name = "tb_lev_price";
            this.tb_lev_price.Size = new System.Drawing.Size(100, 20);
            this.tb_lev_price.TabIndex = 12;
            this.tb_lev_price.TextChanged += new System.EventHandler(this.tb_lev_price_TextChanged);
            this.tb_lev_price.Click += new System.EventHandler(this.tb_lev_price_TextChanged);
            this.tb_lev_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Leverage Multiple";
            // 
            // tb_lev_mult
            // 
            this.tb_lev_mult.Location = new System.Drawing.Point(257, 158);
            this.tb_lev_mult.Name = "tb_lev_mult";
            this.tb_lev_mult.ReadOnly = true;
            this.tb_lev_mult.Size = new System.Drawing.Size(64, 20);
            this.tb_lev_mult.TabIndex = 14;
            this.tb_lev_mult.TextChanged += new System.EventHandler(this.tb_lev_mult_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Share Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "by Debankan Roy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trade Amount";
            // 
            // tb_trade_amt
            // 
            this.tb_trade_amt.Location = new System.Drawing.Point(243, 257);
            this.tb_trade_amt.Name = "tb_trade_amt";
            this.tb_trade_amt.ReadOnly = true;
            this.tb_trade_amt.Size = new System.Drawing.Size(100, 20);
            this.tb_trade_amt.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Price";
            // 
            // tb_total_price
            // 
            this.tb_total_price.Location = new System.Drawing.Point(110, 350);
            this.tb_total_price.Name = "tb_total_price";
            this.tb_total_price.ReadOnly = true;
            this.tb_total_price.Size = new System.Drawing.Size(100, 20);
            this.tb_total_price.TabIndex = 20;
            // 
            // label_price_acc_percentage
            // 
            this.label_price_acc_percentage.AutoSize = true;
            this.label_price_acc_percentage.Location = new System.Drawing.Point(216, 353);
            this.label_price_acc_percentage.Name = "label_price_acc_percentage";
            this.label_price_acc_percentage.Size = new System.Drawing.Size(105, 13);
            this.label_price_acc_percentage.TabIndex = 21;
            this.label_price_acc_percentage.Text = "0% of Account value";
            // 
            // tb_manual_invest
            // 
            this.tb_manual_invest.Location = new System.Drawing.Point(109, 306);
            this.tb_manual_invest.Name = "tb_manual_invest";
            this.tb_manual_invest.ReadOnly = true;
            this.tb_manual_invest.Size = new System.Drawing.Size(100, 20);
            this.tb_manual_invest.TabIndex = 23;
            this.tb_manual_invest.TextChanged += new System.EventHandler(this.tb_manual_invest_TextChanged);
            this.tb_manual_invest.Click += new System.EventHandler(this.tb_manual_invest_Click);
            this.tb_manual_invest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // cb_manual_invest
            // 
            this.cb_manual_invest.AutoSize = true;
            this.cb_manual_invest.Location = new System.Drawing.Point(12, 308);
            this.cb_manual_invest.Name = "cb_manual_invest";
            this.cb_manual_invest.Size = new System.Drawing.Size(93, 17);
            this.cb_manual_invest.TabIndex = 24;
            this.cb_manual_invest.Text = "Manual Invest";
            this.cb_manual_invest.UseVisualStyleBackColor = true;
            this.cb_manual_invest.CheckedChanged += new System.EventHandler(this.cb_manual_invest_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 407);
            this.Controls.Add(this.cb_manual_invest);
            this.Controls.Add(this.tb_manual_invest);
            this.Controls.Add(this.label_price_acc_percentage);
            this.Controls.Add(this.tb_total_price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_trade_amt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_lev_mult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_lev_price);
            this.Controls.Add(this.tb_sq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_sl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_share_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_risk_amt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_risk_percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_acct_val);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trade Risk Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_acct_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_risk_percent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_risk_amt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_share_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sq;
        private System.Windows.Forms.TextBox tb_lev_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_lev_mult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_trade_amt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_total_price;
        private System.Windows.Forms.Label label_price_acc_percentage;
        private System.Windows.Forms.TextBox tb_manual_invest;
        private System.Windows.Forms.CheckBox cb_manual_invest;
    }
}

