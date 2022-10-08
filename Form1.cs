using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Debug.WriteLine("Hello World!");
            //MessageBox.Show("Hello World!");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // 文字から数値へ変換する
            int price;
            bool success = int.TryParse(this.txtPrice.Text, out price);

            if(success)
            {
                // 消費税を計算する
                int taxPrice = (int)(price * 1.1);
                this.txtTaxPrice.Text = taxPrice.ToString();
            }
            else
            {
                MessageBox.Show("数値に変換できませんでした");
            }
        }
    }
}
