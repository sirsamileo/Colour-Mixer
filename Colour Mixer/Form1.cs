using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colour_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (redButton.Checked && radioButton2.Checked)
            {
                Color mixedColor = Color.Orange; 

                this.BackColor = mixedColor;
            }
            else if (redButton.Checked && radioButton1.Checked)
            {
                Color mixedColor = Color.Purple;

                this.BackColor = mixedColor;
            }
            else if (blueButton.Checked && radioButton2.Checked)
            {
                Color mixedColor = Color.Green;

                this.BackColor = mixedColor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
