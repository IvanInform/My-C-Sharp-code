using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLessonShag
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Cursor Files|*.txt";  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                  System.IO.FileInfo f = new FileInfo(openFileDialog1.FileName);
                    long length = f.Length;
                progressBar1.Maximum=(int)length;
                
                char[] c = null;

                while (sr.Peek() >= 0)
                {
                    c = new char[1];
                    sr.Read(c, 0, c.Length);
                   progressBar1.Value+=1;
                }
                sr.Close();
            }  
        }
    }
}
