using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBoxF.Visible = false;
            buttonClear.Visible = false;
            buttonQuit.Visible = false;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double celsius = 0;    

            try {
                celsius = Convert.ToDouble(textBoxC.Text);
            }
            catch (Exception) {
                MessageBox.Show("Enter a valid number stupid!");
                textBoxC.Text = "";
                textBoxC.Focus();
            }

            double fahrenheit = (9.0 / 5.0) * celsius + 32;

            textBoxF.Text = fahrenheit.ToString();

            label3.Visible = true;
            textBoxF.Visible = true;
            buttonClear.Visible = true;
            buttonQuit.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
            textBoxC.Focus();
        }
    }
}
