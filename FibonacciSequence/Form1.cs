using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FibonacciSequence
{
    public partial class Form1 : Form
    {
        public long n1 = 1;
        public long n2 = 1;
        public long n3;
        public long n4;
        public List<String> results = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private String fib(long a)
        {
            n1 = a;
            n2 = a;

            for(int i=0; i<=20; i++)
            {
                results.Add(n1.ToString());
                results.Add(n2.ToString());

                n3 = n1 + n2;
                n4 = n3 + n2;

                n1 = n3;
                n2 = n4;
            }

            return String.Join(Environment.NewLine, results.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            results.Clear();              
                       
            MessageBox.Show(fib(long.Parse(startNumBox.Text)), "Results");

        }
    }
}
