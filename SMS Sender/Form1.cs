using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Sender
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string message = richTextBox1.Text;


            label3.Text = "Opening Serial Port COM7";

            Thread.Sleep(1500);

            Thread.Sleep(1500);

            label3.Text = "Setting to Text Mode";

            Thread.Sleep(1500);

            Thread.Sleep(1500);

            label3.Text = "Writing Message";

            Thread.Sleep(1500);

            Thread.Sleep(1500);

            label3.Text = "Message sent";
        }
    }
}