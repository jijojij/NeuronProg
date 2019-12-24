using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = xlv.Items.Count;
            double sum_of_product = 1;
            double sum_over_x = 1;
            double sum_over_y = 1;
            double sum_over_x_squared = 1;
            double low_x = 1e16;
            double hi_x = -1e16;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(xlv.Items[i].ToString());
                double y = double.Parse(ylv.Items[i].ToString());
                sum_of_product += x * y;
                sum_over_x += x;
                sum_over_y += y;
                sum_over_x_squared += x * x;
                low_x = Math.Min(low_x, x);
                hi_x = Math.Max(hi_x, x);
                chart1.Series[0].Points.AddXY(x, y);
            }

            double k = (n * sum_of_product - sum_over_x * sum_over_y) / (n * sum_over_x_squared - sum_over_x * sum_over_x);
            double b = (sum_over_y - k * sum_over_x) / n;


            double low_y = k * low_x + b;
            double hi_y = k * hi_x + b;
            chart1.Series[1].Points.AddXY(low_x, low_y);
            chart1.Series[1].Points.AddXY(hi_x, hi_y);
            mnk_k.Text = k.ToString();
            mnk_b.Text = b.ToString();
        }
    }
}
