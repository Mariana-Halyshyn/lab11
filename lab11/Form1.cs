using KompleksneChysloApp;
using System;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text.Trim();
            string[] parts = input.Split(' ');

            if (parts.Length == 2)
            {
                try
                {
                    double real = Convert.ToDouble(parts[0]);
                    double imaginary = Convert.ToDouble(parts[1]);
                    var complex = new Kompleksne_chyslo(real, imaginary);
                    listBoxNumbers.Items.Add(complex);
                    textBoxInput.Clear();
                }
                catch
                {
                    MessageBox.Show("Невірний формат. Введіть два числа через пробіл.");
                }
            }
            else
            {
                MessageBox.Show("Введіть два числа через пробіл.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.Items.Count >= 2)
            {
                var num1 = (Kompleksne_chyslo)listBoxNumbers.Items[0];
                var num2 = (Kompleksne_chyslo)listBoxNumbers.Items[1];
                var result = num1.Add(num2);
                textBoxResult.Text = "Результат: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Введіть щонайменше два числа.");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.Items.Count >= 2)
            {
                var num1 = (Kompleksne_chyslo)listBoxNumbers.Items[0];
                var num2 = (Kompleksne_chyslo)listBoxNumbers.Items[1];
                var result = num1.Multiply(num2);
                textBoxResult.Text = "Результат: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Введіть щонайменше два числа.");
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.Items.Count >= 2)
            {
                var num1 = (Kompleksne_chyslo)listBoxNumbers.Items[0];
                var num2 = (Kompleksne_chyslo)listBoxNumbers.Items[1];

                bool isEqual = num1.EqualsTo(num2);
                textBoxResult.Text = isEqual ? "Числа рівні" : "Числа не рівні";
            }
            else
            {
                MessageBox.Show("Введіть щонайменше два числа.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}



