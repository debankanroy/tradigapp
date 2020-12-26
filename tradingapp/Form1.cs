using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace tradingapp
{
    public partial class Form1 : Form
    {
        DataTable dt;
        private void InitializeDatable()
        {
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Lev Price");
            dt.Columns.Add("Lev Mult");
            dt.Columns.Add("SL");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Trade Amt");
            dt.Columns.Add("Manual Amt");
            dt.Columns.Add("Tot price");
            dt.Columns.Add("Tot price %");
            dt.Columns.Add("Acct Value");
            dt.Columns.Add("Risk %");
            dt.Columns.Add("Risk Amt");

            dataGridView1.DataSource = dt;
        }
        public Form1()
        {
            InitializeComponent();
            InitializeDatable();
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
                if (tb_lev_price.Text == "" || tb_share_price.Text == "" || tb_sl.Text == "" || tb_risk_amt.Text == "" || tb_acct_val.Text == "")
                    return;
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
                tb_risk_percent.ReadOnly = true;
                tb_manual_invest.ReadOnly = false;
            }
            else
            {
                tb_risk_percent.ReadOnly = false;
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

        private void button_add_entry_Click(object sender, EventArgs e)
        {
            //dataGridView1.r
            /* 
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Lev Price");
            dt.Columns.Add("Lev Mult");
            dt.Columns.Add("SL");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Trade Amt");
            dt.Columns.Add("Manual Amt");
            dt.Columns.Add("Tot price");
            dt.Columns.Add("Tot price %");
            dt.Columns.Add("Acct Value");
            dt.Columns.Add("Risk");
            dt.Columns.Add("Risk Amt");
             
             */
            var row = dt.NewRow();

            row["Name"] = tb_share_name.Text == "" ? "NA" : tb_share_name.Text;
            row["Price"] = tb_share_price.Text == "" ? "NA" :tb_share_price.Text;
            row["Lev Price"] = tb_lev_price.Text == "" ? "NA" :tb_share_price.Text;
            row["Lev Mult"] = tb_lev_mult.Text == "" ? "NA" :tb_lev_mult.Text;
            row["SL"] = tb_sl.Text == "" ? "NA" :tb_sl.Text;
            row["QTY"] = tb_sq.Text == "" ? "NA" :tb_sq.Text;
            row["Trade Amt"] = tb_trade_amt.Text == "" ? "NA" :tb_trade_amt.Text;
            row["Manual Amt"] = tb_manual_invest.Text == "" || cb_manual_invest.Checked == false ? "NA" :tb_manual_invest.Text;
            row["Tot price"] = tb_total_price.Text == "" ? "NA" :tb_total_price.Text;
            row["Tot price %"] = label_price_acc_percentage.Text == "" ? "NA" :label_price_acc_percentage.Text.Split('%')[0];
            row["Acct Value"] = tb_acct_val.Text == "" ? "NA" :tb_acct_val.Text;
            row["Risk %"] = tb_risk_percent.Text == "" ? "NA" :tb_risk_percent.Text;
            row["Risk Amt"] = tb_risk_amt.Text == "" ? "NA" : tb_risk_amt.Text;

            dt.Rows.Add(row);
        }

        private string OpenFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                        //fileContent = reader.ReadToEnd();
                    //}
                }
            }
            if (filePath == "")
                return "";
            else
                return filePath;

        }


        private string SaveFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            

                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory  = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;
                }
            
            if (filePath == "")
                return "";
            else
                return filePath;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


            StringBuilder sb = new StringBuilder();
            string filePath;

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            filePath = SaveFile();
            if (filePath == "")
                return ;

            File.WriteAllText(filePath, sb.ToString());
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string filePath = OpenFile();
            if (filePath == "")
                return;

            StreamReader sr = new StreamReader(filePath);
            dt.Rows.Clear();
            dt.Columns.Clear();
            
                
               string[] headers = sr.ReadLine().Split(',');
               for (int i = 0; i < headers.Count(); i++)
               {
                   dt.Columns.Add(headers[i]);
               }
               while (!sr.EndOfStream)
               {
                   string[] rows = sr.ReadLine().Split(',');
                   DataRow dr = dt.NewRow();
                   for (int i = 0; i < rows.Count(); i++)
                   {
                       dr[i] = rows[i];
                   }
                   dt.Rows.Add(dr);
               }
               dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView1.Columns.
            
        }

        private void picture_kite_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://kite.zerodha.com/dashboard");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.tradingview.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www1.nseindia.com/live_market/dynaContent/live_watch/equities_stock_watch.htm");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://economictimes.indiatimes.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.youtube.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.investing.com/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.pivottrading.co.in/scanner/openHighLowScanner.php");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.moneycontrol.com/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.bloomberg.com/");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://in.reuters.com/");
        }
    }
} 
