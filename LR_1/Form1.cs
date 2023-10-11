using System;
using System.Data;

namespace LR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double h = Convert.ToSingle(textBox1.Text);
            double R = Convert.ToSingle(textBox3.Text);
            double L = Convert.ToSingle(textBox2.Text);
            const double PI = 3.1415;


            double V = 0.3334 * PI * R * R * h;
            double S = PI * R * (L + R);
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox4.Text = V.ToString() + ";" + S.ToString();
            }
            else if (checkBox1.Checked)
            {
                textBox4.Text = V.ToString();


            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = S.ToString();
            }
            else
            {
                textBox4.Text = "Не выбран режим!";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}