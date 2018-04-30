using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBFactoryProvider
{
    public partial class readFileDialog : Form
    {
        string str;
        contents content = null;
        public readFileDialog()
        {
            InitializeComponent();
            content = new contents();
        }
        class contents {
            public string str { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();

            if (fl.ShowDialog() == DialogResult.OK) {
                str = File.ReadAllText(fl.FileName);
                if (string.IsNullOrEmpty(str) != true)
                { richTextBox1.Text = str;

                content.str = str;
                }
            }
        }
        class dialogform : Form {
            RichTextBox text1 = null;
            FlowLayoutPanel panel = null;
            Button btn = null;
            contents ctn;
            public dialogform() {
                this.Width = 500;
                this.Height = 400;
                text1 = new RichTextBox();
                text1.Width = 300;
                text1.Height = 200;
                panel = new FlowLayoutPanel();
                panel.SetBounds(10,10,300,400);
                btn = new Button();
                btn.Width = 100;
                btn.Height = 40;
                btn.Text = "Сохранить";
                btn.Click += new EventHandler(btn_Click);
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Controls.Add(text1);
                panel.Controls.Add(btn);
                this.Controls.Add(panel);
                ctn = new contents();
           
            }

            private void btn_Click(object sender, EventArgs e)
            {
                char[] array = text1.Text.ToCharArray();
                ctn.str = new string(array);
               this.DialogResult = DialogResult.OK;
              
            }
            public DialogResult ShowDialog(contents str) {
                ctn = str;
                text1.Text = ctn.str;
                             
                return ShowDialog();
            }



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogform frm = new dialogform();
            DialogResult result= frm.ShowDialog(this.content);
            if (result == DialogResult.OK) {
                richTextBox1.Text = content.str;
                this.Update();
            }
        }
    }
}
