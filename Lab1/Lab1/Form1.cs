using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float constant = 0;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 dlg = new Form2();
                dlg.ShowDialog();
                double result;
                if (dlg.constant == 1)
                {
                    result = Math.Sqrt(Convert.ToDouble(this.textBox1.Text));
                    this.textBox1.Text = Convert.ToString((float)result);
                    MessageBox.Show("sqrt with first element");
                }
                if (dlg.constant == 2)
                {
                    result = Math.Sqrt(Convert.ToDouble(this.textBox2.Text));
                    this.textBox2.Text = Convert.ToString((float)result);
                    MessageBox.Show("sqrt with second element");
                }
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 dlg = new Form2();
                double result;
                dlg.ShowDialog();
                if (dlg.constant == 1)
                {
                    result = Math.Sin(Convert.ToDouble(this.textBox1.Text));
                    this.textBox1.Text = Convert.ToString((float)result);
                    MessageBox.Show("sin of first element");
                }
                if (dlg.constant == 2)
                {
                    result = Math.Sin(Convert.ToDouble(this.textBox2.Text));
                    this.textBox2.Text = Convert.ToString((float)result);
                    MessageBox.Show("sin of second element");
                }
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }
        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 dlg = new Form2();
                double result;
                dlg.ShowDialog();
                if (dlg.constant == 1)
                {
                    result = Math.Cos(Convert.ToDouble(this.textBox1.Text));
                    this.textBox1.Text = Convert.ToString((float)result);
                    MessageBox.Show("cos of first element");
                }
                if (dlg.constant == 2)
                {
                    result = Math.Cos(Convert.ToDouble(this.textBox2.Text));
                    this.textBox2.Text = Convert.ToString((float)result);
                    MessageBox.Show("cos of second element");
                }
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) + Convert.ToSingle(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) - Convert.ToSingle(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) * Convert.ToSingle(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToSingle(textBox2.Text) != 0)
                {
                    textBox3.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) / Convert.ToSingle(textBox2.Text));
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("error: divide by zero");
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                this.constant = Convert.ToSingle(textBox3.Text);
                Data.Text = textBox3.Text;
            }
            catch
            {
                MessageBox.Show("error: invalid character");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.constant = 0;
        }

        private void insert_first_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.ShowDialog();
            if (dlg.constant == 1)
            {
                this.textBox1.Text = Convert.ToString(this.constant);
                MessageBox.Show("copy in first element");
            }
            if (dlg.constant == 2)
            {
                this.textBox2.Text = Convert.ToString(this.constant);
                MessageBox.Show("copy in second element");
            }
            Data.Text = Convert.ToString(this.constant);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
