using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronProg
{
    class Perceptron
    {
        double eps;
        double ro;
        double bias;
        List<double> weights;
        List<double> inputs;

        public Perceptron(int n, double r, double eps)
        {
            this.eps = eps;
            ro = r;
            for (int i = 0; i < n; i++)
            {
                weights.Add(0);
                inputs.Add(0);
            }
        }

        public void SetRandomWeights(double min, double max)
        {
            Random rnd = new Random();
            for (int i = 0; i < weights.Count(); i++)
            {
                double d = Math.Round(min + rnd.NextDouble() * (max + (min * -1)), 13);
                weights[i] = d;
            }
        }

        public void SetRandomBias(double min, double max)
        {
            Random rnd = new Random();
            bias = Math.Round(min + rnd.NextDouble() * (max + (min * -1)), 13);
        }

        public void SetInput(List<double> input)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                inputs[i] = input[i];
            }
        }

        public double Evaluate()
        {
            double ans = bias;
            for (int i = 0; i < inputs.Count; i++)
            {
                ans += inputs[i] * weights[i];
            }
            return ans;
        }

        public double getWeight(int i)
        {
            return weights[i];
        }
        public double getBias()
        {
            return bias;
        }
        public void CorrectWeights(double delta)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                weights[i] += delta * ro * inputs[i];
            }
            bias += delta * ro;
        }

        public void Train(int epochs, List<KeyValuePair<List<double>, double>> data)
        {
            bool can = true;
            for (int i = 0; i < epochs; i++)
            {
                can = true;
                for (int j = 0; j < data.Count; j++)
                {
                    SetInput(data[j].Key);
                    double result = Evaluate();
                    double expected = data[j].Value;
                    if (Math.Abs(expected - result) > eps)
                    {
                        can = false;
                        CorrectWeights(expected - result);
                    }
                }
            }
        }
    }
}
