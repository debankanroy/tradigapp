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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add_entry = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_share_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_kite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kite)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(280, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Risked Amt";
            // 
            // tb_risk_amt
            // 
            this.tb_risk_amt.Location = new System.Drawing.Point(263, 68);
            this.tb_risk_amt.Name = "tb_risk_amt";
            this.tb_risk_amt.ReadOnly = true;
            this.tb_risk_amt.Size = new System.Drawing.Size(100, 20);
            this.tb_risk_amt.TabIndex = 5;
            this.tb_risk_amt.TextChanged += new System.EventHandler(this.tb_risk_amt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Share price";
            // 
            // tb_share_price
            // 
            this.tb_share_price.Location = new System.Drawing.Point(109, 154);
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
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop Loss";
            // 
            // tb_sl
            // 
            this.tb_sl.Location = new System.Drawing.Point(109, 239);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(100, 20);
            this.tb_sl.TabIndex = 9;
            this.tb_sl.TextChanged += new System.EventHandler(this.tb_sl_TextChanged);
            this.tb_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_acct_val_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Leverage price";
            // 
            // tb_sq
            // 
            this.tb_sq.Location = new System.Drawing.Point(109, 288);
            this.tb_sq.Name = "tb_sq";
            this.tb_sq.ReadOnly = true;
            this.tb_sq.Size = new System.Drawing.Size(100, 20);
            this.tb_sq.TabIndex = 11;
            // 
            // tb_lev_price
            // 
            this.tb_lev_price.Location = new System.Drawing.Point(109, 192);
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
            this.label7.Location = new System.Drawing.Point(269, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Leverage Multiple";
            // 
            // tb_lev_mult
            // 
            this.tb_lev_mult.Location = new System.Drawing.Point(277, 188);
            this.tb_lev_mult.Name = "tb_lev_mult";
            this.tb_lev_mult.ReadOnly = true;
            this.tb_lev_mult.Size = new System.Drawing.Size(64, 20);
            this.tb_lev_mult.TabIndex = 14;
            this.tb_lev_mult.TextChanged += new System.EventHandler(this.tb_lev_mult_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Share Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(932, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "by Debankan Roy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trade Amount";
            // 
            // tb_trade_amt
            // 
            this.tb_trade_amt.Location = new System.Drawing.Point(263, 287);
            this.tb_trade_amt.Name = "tb_trade_amt";
            this.tb_trade_amt.ReadOnly = true;
            this.tb_trade_amt.Size = new System.Drawing.Size(100, 20);
            this.tb_trade_amt.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Price";
            // 
            // tb_total_price
            // 
            this.tb_total_price.Location = new System.Drawing.Point(110, 384);
            this.tb_total_price.Name = "tb_total_price";
            this.tb_total_price.ReadOnly = true;
            this.tb_total_price.Size = new System.Drawing.Size(100, 20);
            this.tb_total_price.TabIndex = 20;
            // 
            // label_price_acc_percentage
            // 
            this.label_price_acc_percentage.AutoSize = true;
            this.label_price_acc_percentage.Location = new System.Drawing.Point(216, 387);
            this.label_price_acc_percentage.Name = "label_price_acc_percentage";
            this.label_price_acc_percentage.Size = new System.Drawing.Size(105, 13);
            this.label_price_acc_percentage.TabIndex = 21;
            this.label_price_acc_percentage.Text = "0% of Account value";
            // 
            // tb_manual_invest
            // 
            this.tb_manual_invest.Location = new System.Drawing.Point(109, 340);
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
            this.cb_manual_invest.Location = new System.Drawing.Point(12, 342);
            this.cb_manual_invest.Name = "cb_manual_invest";
            this.cb_manual_invest.Size = new System.Drawing.Size(93, 17);
            this.cb_manual_invest.TabIndex = 24;
            this.cb_manual_invest.Text = "Manual Invest";
            this.cb_manual_invest.UseVisualStyleBackColor = true;
            this.cb_manual_invest.CheckedChanged += new System.EventHandler(this.cb_manual_invest_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 129);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // button_add_entry
            // 
            this.button_add_entry.Location = new System.Drawing.Point(49, 430);
            this.button_add_entry.Name = "button_add_entry";
            this.button_add_entry.Size = new System.Drawing.Size(75, 23);
            this.button_add_entry.TabIndex = 26;
            this.button_add_entry.Text = "add";
            this.button_add_entry.UseVisualStyleBackColor = true;
            this.button_add_entry.Click += new System.EventHandler(this.button_add_entry_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Share Name";
            // 
            // tb_share_name
            // 
            this.tb_share_name.Location = new System.Drawing.Point(109, 121);
            this.tb_share_name.Name = "tb_share_name";
            this.tb_share_name.Size = new System.Drawing.Size(100, 20);
            this.tb_share_name.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::tradingapp.Properties.Resources.pivot_trading;
            this.pictureBox9.Location = new System.Drawing.Point(764, 168);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(121, 117);
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::tradingapp.Properties.Resources.reuters;
            this.pictureBox8.Location = new System.Drawing.Point(764, 291);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 117);
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::tradingapp.Properties.Resources.bloomberglp;
            this.pictureBox7.Location = new System.Drawing.Point(637, 291);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(121, 117);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::tradingapp.Properties.Resources.MONEY_CONTROL_LOGO;
            this.pictureBox6.Location = new System.Drawing.Point(510, 291);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(121, 117);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::tradingapp.Properties.Resources.ET;
            this.pictureBox5.Location = new System.Drawing.Point(891, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 117);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::tradingapp.Properties.Resources.investing;
            this.pictureBox4.Location = new System.Drawing.Point(637, 161);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 117);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::tradingapp.Properties.Resources.youtube;
            this.pictureBox3.Location = new System.Drawing.Point(510, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 117);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tradingapp.Properties.Resources.nse_logo;
            this.pictureBox2.Location = new System.Drawing.Point(764, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 117);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tradingapp.Properties.Resources.trading_view;
            this.pictureBox1.Location = new System.Drawing.Point(637, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picture_kite
            // 
            this.picture_kite.Image = global::tradingapp.Properties.Resources.kite;
            this.picture_kite.Location = new System.Drawing.Point(510, 32);
            this.picture_kite.Name = "picture_kite";
            this.picture_kite.Size = new System.Drawing.Size(121, 117);
            this.picture_kite.TabIndex = 31;
            this.picture_kite.TabStop = false;
            this.picture_kite.Click += new System.EventHandler(this.picture_kite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1049, 630);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture_kite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_share_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_add_entry);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_kite)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_entry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_share_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picture_kite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

