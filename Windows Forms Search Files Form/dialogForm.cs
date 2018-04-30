using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessonThree
{
 
    public partial class dialogForm : Form
    {
        class child : dialogForm {
            
          public  TextBox txt = new TextBox();
          public string Txt {
              get { return txt.Text; }
          }
          private Button btn1 = new Button();
            public child(string s){
                InitializeComponent();
            txt.SetBounds(10, 10, 100, 20);
            txt.Text = s;
            this.Controls.Add(txt);
            this.Controls.Remove(btn);
            this.Update();
            this.btn1.Text = "return result";
            this.btn1.SetBounds(40, 10, 100, 40);
            this.btn1.Click += new EventHandler(btn1_Click);
            this.Controls.Remove(this.list);
            this.Update();
            this.Controls.Add(this.btn1);
            }



            public void btn1_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
            
                       }
        }
        public Button btn = new Button();
        public ListBox list = new ListBox();

        public dialogForm()
        {
            InitializeComponent();
            list.SetBounds(10, 10, 150, 150);
            this.Controls.Add(list);
            btn.SetBounds(this.Width / 2, this.Height / 2+20,
                100, 30);
            btn.Text = "New Form";
            this.Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            child Child= new child("this is string");
            Child.txt.Text = this.btn.Text;
            Child.ShowDialog();
            if (Child.DialogResult == DialogResult.OK) {

                this.list.Items.Add(Child.Txt);
            }

            
        }
    }
}
