﻿using System;
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Точки");
            chart1.Series.Add("МНК");
            chart1.Series.Add("Персептрон");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<List<double>, double>> td = new List<KeyValuePair<List<double>, double>>();
            int n = xlv.Items.Count;
            double low_x = 1e16;
            double hi_x = -1e16;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(xlv.Items[i].ToString());
                double y = double.Parse(ylv.Items[i].ToString());
                low_x = Math.Min(low_x, x);
                hi_x = Math.Max(hi_x, x);
                td.Add(new KeyValuePair<List<double>, double>(new List<double> { x },y));
            }
            double ro = double.Parse(ro_tb.Text);
            double eps = double.Parse(e_tb.Text);
            int epochs = Int32.Parse(epoch_tb.Text);
            double mn_w = double.Parse(min_tb.Text);
            double mx_w = double.Parse(max_tb.Text);
            Perceptron p = new Perceptron(1, ro, eps);
            p.SetRandomWeights(mn_w, mx_w);
            p.SetRandomBias(mn_w, mx_w);
            p.Train(epochs, td);

            List<double> _ = new List<double> { low_x };
            p.SetInput(_);
            double low_y = p.Evaluate();
            _ = new List<double> { hi_x };
            p.SetInput(_);
            double hi_y = p.Evaluate();
            chart1.Series[2].Points.Clear();
            chart1.Series[2].Points.AddXY(low_x, low_y);
            chart1.Series[2].Points.AddXY(hi_x, hi_y);
            p_k.Text = p.getWeight(0).ToString();
            p_b.Text = p.getBias().ToString();

        }
    }
}
