using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Question 1

        private void g1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (q1A1.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Green;
                labelQ1Feedback.Text = "\u00fc"; //tick
            }
        }

        private void q1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (q1A2.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Red;
                labelQ1Feedback.Text = "\u00fb"; //cross
            }
        }

        private void g1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (q1A3.Checked)
            {
                labelQ1Feedback.ForeColor = Color.Red;
                labelQ1Feedback.Text = "\u00fb"; //cross
            }
        }

        // Question 2

        private void q2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (q2A1.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb"; //cross
            }
        }

        private void q2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (q2A2.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb"; //cross
            }
        }

        private void q2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (q2A3.Checked)
            {
                label4.ForeColor = Color.Green;
                label4.Text = "\u00fc"; //tick
            }
        }
    }
}
