using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLesson
{
    public partial class Form1 : Form
    {
         Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(showTimer);
        }

        private void showTimer(object vObject, EventArgs e)
        {
            timer.Stop();
            button2.Enabled = false;
            label1.Text="Timer worked!";
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0) { return; }
            button2.Enabled = true;
            timer.Interval = Decimal.ToInt32(numericUpDown1.Value) * 1000;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "Timer didn't complete";
        }

    }
}
