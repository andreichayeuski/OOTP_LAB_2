using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_task2
{
    public partial class Form2 : Form
    {
        public short kurs;

        public Form2()
        {
            InitializeComponent();
        }

        private void Agree_Click(object sender, EventArgs e)
        {
            try
            {
                short kurs;
                if (this.Kurs.Text != "" && (kurs = Convert.ToInt16(this.Kurs.Text)) > 0 && kurs < 5)
                {
                    this.kurs = kurs;
                }
                else
                {
                    this.kurs = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            this.Close();
        }
    }
}
