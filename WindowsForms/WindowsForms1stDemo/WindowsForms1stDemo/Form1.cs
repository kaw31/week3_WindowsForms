using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1stDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dTPBirthDate.Value;
            int years = (int)ageDays.TotalDays / 365;

            int day = dTPBirthDate.Value.Day;
            string month = dTPBirthDate.Value.ToString("MMMM");

            labelMsg.Text = "Hello, " + userName.Text + "! You will be " + (years + 1) + "years old on " + day + " " + month + "." + " You are " + (int)ageDays.TotalDays + "days old.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
