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
            string S ="ФИО:"+ textBox3.Text+" "+ textBox1.Text + " " +textBox2.Text+ "\nУвлечения: ";

            var checkboxList_U = new List<CheckBox>
            {checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6};
            var messages = checkboxList_U.Where(x => x.Checked).Select(x => x.Text);
            string U = string.Join(", ", messages);


            MessageBox.Show(S + U, "A message", MessageBoxButtons.OKCancel);
        }
    }
}