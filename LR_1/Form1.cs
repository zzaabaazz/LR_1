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
            string S = "ФИО:" + textBox3.Text + " " + textBox1.Text + " " + textBox2.Text + "\nУвлечения: ";

            var checkboxList_U = new List<CheckBox>
            {checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6};
            var messages_U = checkboxList_U.Where(x => x.Checked).Select(x => x.Text);
            string U = string.Join(", ", messages_U);
            U = U + ("\nОбразование: ");
            var checkboxList_O = new List<RadioButton>
            {radioButton1,radioButton2,radioButton3};
            var messages_O = checkboxList_O.Where(x => x.Checked).Select(x => x.Text);
            string O = string.Join(", ", messages_O);
            O = O + ("\nПол: ");
            var checkboxList_G = new List<RadioButton>
            {radioButton5,radioButton6};
            var messages_G = checkboxList_G.Where(x => x.Checked).Select(x => x.Text);
            string G = string.Join(", ", messages_G);

            MessageBox.Show(S + U +O+G, "A message", MessageBoxButtons.OKCancel);
        }
    }
}