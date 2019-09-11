using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtocultar.Text == "1")
                pictureBox1.Visible = false;
            else
                if (txtocultar.Text == "2")
                    pictureBox2.Visible = false;
                else
                    if (txtocultar.Text == "3")
                        pictureBox3.Visible = false;
                    else
                        if (txtocultar.Text == "4")
                            pictureBox4.Visible = false;
                        else
                            if (txtocultar.Text == "5")
                                pictureBox5.Visible = false;
        }
    }
}
