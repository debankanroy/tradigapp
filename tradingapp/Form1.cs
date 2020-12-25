using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tradingapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       // private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        //private static bool IsTextAllowed(string text)
        //{
            //return !_regex.IsMatch(text);
        //}

        private void calculate_Risked_amt()
        {
            if (tb_acct_val.Text == "" || tb_risk_percent.Text == "")
            {
                tb_risk_amt.Text = "0";
            }
            else
            {
                tb_risk_amt.Text = (float.Parse(tb_acct_val.Text) * float.Parse(tb_risk_percent.Text) / 100).ToString();
            }
        }

        private void calculate_Lev_mult()
        {
            if (tb_share_price.Text == "" || tb_lev_price.Text == "")
            {
                tb_lev_mult.Text = "1";
            }
            else
            {
                tb_lev_mult.Text = (float.Parse(tb_share_price.Text) / float.Parse(tb_lev_price.Text)).ToString();
            }
        }

        private void calculate_share_qty()
        {
            if (cb_manual_invest.Checked == true)
            {
                calculate_manual_share_qty();
            }
            else
            {
                calculate_auto_share_qty();
            }

        }

        private void calculate_auto_share_qty()
        {
            if (tb_share_price.Text == "" || tb_sl.Text == "" || tb_risk_amt.Text == "")
            {
                tb_sq.Text = "0";
                tb_trade_amt.Text = "0";
                tb_total_price.Text = "0";
                label_price_acc_percentage.Text = "0% of Account value";
            }
            else
            {
                tb_sq.Text = (float.Parse(tb_risk_amt.Text) / Math.Abs(float.Parse(tb_share_price.Text) - float.Parse(tb_sl.Text))).ToString();
                tb_trade_amt.Text = (float.Parse(tb_sq.Text) * float.Parse(tb_share_price.Text)).ToString();
                tb_total_price.Text = (float.Parse(tb_trade_amt.Text) / float.Parse(tb_lev_mult.Text)).ToString();
                
                float price_acc = 0;
                if (tb_acct_val.Text != "")
                {
                    price_acc = float.Parse(tb_total_price.Text) * 100 / float.Parse(tb_acct_val.Text);
                    label_price_acc_percentage.Text = price_acc.ToString("0.00") + "% of Account value";
                }
            }
        }

        private void calculate_manual_share_qty()
        {
            if (tb_manual_invest.Text == "" )
            {
               
            }
            else
            {
                tb_sq.Text = (float.Parse(tb_manual_invest.Text)  / float.Parse(tb_lev_price.Text)).ToString();
                tb_trade_amt.Text = (float.Parse(tb_sq.Text) * float.Parse(tb_share_price.Text)).ToString();
                tb_risk_amt.Text = (float.Parse(tb_sq.Text) * Math.Abs(float.Parse(tb_share_price.Text) - float.Parse(tb_sl.Text))).ToString();
                tb_risk_percent.Text = (float.Parse(tb_risk_amt.Text) * 100 / float.Parse(tb_acct_val.Text)).ToString();
                tb_total_price.Text = tb_manual_invest.Text;

                float price_acc = 0;
                if (tb_acct_val.Text != "")
                {
                    price_acc = float.Parse(tb_total_price.Text) * 100 / float.Parse(tb_acct_val.Text);
                    label_price_acc_percentage.Text = price_acc.ToString("0.00") + "% of Account value";
                }
            }
        }

        private void tb_acct_val_TextChanged(object sender, EventArgs e)
        {
            calculate_Risked_amt();
        }

        private void tb_acct_val_Click(object sender, EventArgs e)
        {
            calculate_Risked_amt();
        }

        private void tb_risk_percent_TextChanged(object sender, EventArgs e)
        {
            calculate_Risked_amt();
        }

        private void tb_risk_percent_Click(object sender, EventArgs e)
        {
            calculate_Risked_amt();
        }

        private void tb_acct_val_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_share_price_TextChanged(object sender, EventArgs e)
        {
            calculate_Lev_mult();
        }

        private void tb_lev_price_TextChanged(object sender, EventArgs e)
        {
            calculate_Lev_mult();
        }

        private void tb_sl_TextChanged(object sender, EventArgs e)
        {
            calculate_share_qty();
        }

        private void tb_risk_amt_TextChanged(object sender, EventArgs e)
        {
            calculate_share_qty();
        }

        private void tb_lev_mult_TextChanged(object sender, EventArgs e)
        {
            calculate_share_qty();
        }

        private void cb_manual_invest_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_manual_invest.Checked == true)
            {
                //tb_risk_percent.ReadOnly = true;
                tb_manual_invest.ReadOnly = false;
            }
            else
            {
                //tb_risk_percent.ReadOnly = false;
                tb_manual_invest.ReadOnly = true;
            }
        }

        private void tb_manual_invest_TextChanged(object sender, EventArgs e)
        {
            if (cb_manual_invest.Checked == true)
            {
                calculate_share_qty();
            }

        }

        private void tb_manual_invest_Click(object sender, EventArgs e)
        {
            if (cb_manual_invest.Checked == true)
            {
                calculate_share_qty();
            }
        }
    }
}
