using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newWindow = new Form2();
            newWindow.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void Opebutton1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += " " + button.Text + " ";
        }

        private void Opebutton2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += " " + button.Text + " ";
        }

        private void Opebutton4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += " " + button.Text + " ";
        }

        private void Opebutton3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += " " + button.Text + " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string expression = txtDisplay.Text;
                    DataTable dataTable = new DataTable();
                    var result = dataTable.Compute(expression, "");
                    txtDisplay.Text = result.ToString();
                }
                catch (Exception)
                {
                    txtDisplay.Text = "Error";
                }
            }

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            {
                txtDisplay.Text = string.Empty;
            }
        }
    }
}
