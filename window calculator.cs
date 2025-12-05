using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int x, y, z;

        // Method to read numbers safely
        void Calculate()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    throw new Exception("Please enter both numbers.");
                }

                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // ADD
        {
            Calculate();
            z = x + y;
            textBox3.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e) // SUBTRACT
        {
            Calculate();
            z = x - y;
            textBox3.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // MULTIPLY
        {
            Calculate();
            z = x * y;
            textBox3.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e) // DIVIDE
        {
            Calculate();

            try
            {
                if (y == 0)
                {
                    MessageBox.Show("Cannot divide by zero!", "Math Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                z = x / y;
                textBox3.Text = z.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
