namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double num1, num2;
        char action;
        bool sign = true;

        private void calculate()
        {
            switch (action)
            {
                case '+':
                    num2 = num1 + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case '-':
                    num2 = num1 - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case '*':
                    num2 = num1 * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        textBox1.Text = "Деление на 0 запрещено";
                        break;
                    }
                    else
                    {
                        num2 = num1 / Convert.ToDouble(textBox1.Text);
                        textBox1.Text = num2.ToString();
                        break;
                    }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += '/';
            action = '/';
            sign = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += '*';
            action = '*';
            sign = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += '-';
            action = '-';
            sign = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sign)
            {
                textBox1.Text = '-' + textBox1.Text;
                sign = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1);
            calculate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += '+';
            action = '+';
            sign = true;
        }
    }
}