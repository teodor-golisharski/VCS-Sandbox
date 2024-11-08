using System;

namespace _2._4._11
{
    public partial class Form1 : Form
    {
        int tries = 0;
        int count = 0;
        int left = 0;
        int right = 100;
        int current = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            tries = int.Parse(textBox1.Text);


            if (tries != 0)
            {
                textBox1.Enabled = false;
                button3.Enabled = false;

                current = random.Next(left, right);
                textBox2.Text = current.ToString();
                
                count++;
                tries--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text += $"{count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            left = current + 1;

            current = random.Next(left, right);
            textBox2.Text = current.ToString();

            count++;
            tries--;
            if(tries == 0)
            {
                MessageBox.Show("Game Over!");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            right = current - 1;

            current = random.Next(left, right);
            textBox2.Text = current.ToString();

            count++;
            tries--;
            if (tries == 0)
            {
                MessageBox.Show("Game Over!");
                textBox1.Text = "";

            }
        }
    }
}