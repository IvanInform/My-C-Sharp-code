using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace SecondLessonShag
{
    public partial class listBoxDemo : Form
    {
        string str;
        int index;
        string selectedItem;
        public listBoxDemo()
        {
            InitializeComponent();
            str = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Заполните все данные", "Ошибка Ввода Данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                str += textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
                listBox1.Items.Add(str);
                str = "";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            str += textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            List<string> deleteditems = new List<string>();
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().CompareTo(this.selectedItem) == 0)
                {
                    deleteditems.Add(str);
                }
                else { deleteditems.Add(item.ToString()); }
            }
            listBox1.Items.Clear();
            listBox1.Update();
            listBox1.Items.AddRange(deleteditems.ToArray());

            str = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            this.index = list.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                var item = listBox1.SelectedItem.ToString();
                this.selectedItem = item;
                char[] separator = new char[1] { ' ' };
                string[] items = item.Split(separator);
                textBox1.Text = items[0];
                textBox2.Text = items[1];
                textBox3.Text = items[2];
                textBox4.Text = items[3];
            }
            else if (listBox1.Items.Count != 0)
            {
                MessageBox.Show("Не выбраны елементы для редактирования", null, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Список пустой!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(this.selectedItem);
            listBox1.ClearSelected();
            listBox1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File |*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();
 

            if (saveFileDialog1.FileName != "")            
           {
                           
                
                    string writestring = "";
                    foreach (var item in listBox1.Items)
                    {
                        writestring += item.ToString();
                        writestring += "\r\n";
                    }
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    Encoding u8 = Encoding.UTF8;
                    fs.Write(u8.GetBytes(writestring),
           0, u8.GetByteCount(writestring));
                    fs.Close();
                
            }
        }
            else if (radioButton2.Checked) {
                

                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<Personы></Personы>");
XmlElement newElem=null;
XmlElement childElem = null;
               
                string[] stritems = new string[4];
                char[] separator = new char[1] { ' '};
             foreach(var item in listBox1.Items){
                 newElem = doc.CreateElement("Person");
                 doc.DocumentElement.AppendChild(newElem);
                 stritems = item.ToString().Split(separator);
                 for (int i = 0; i < stritems.Length; i++)
                 {
                     switch (i)
                     {
                         case 0:
                             childElem = doc.CreateElement("firstname");
                             childElem.InnerText = stritems[0];
                             newElem.AppendChild(childElem);

                             break;
                         case 1:
                             childElem = doc.CreateElement("lastname");
                             childElem.InnerText = stritems[1];
                             newElem.AppendChild(childElem);
                             break;
                         case 2:
                             childElem = doc.CreateElement("email");
                             childElem.InnerText = stritems[2];
                             newElem.AppendChild(childElem);
                             break;
                         case 3:
                             childElem = doc.CreateElement("phone");
                             childElem.InnerText = stritems[3];
                             newElem.AppendChild(childElem);
                             break;


                     }
                 }
               
               
             }
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             saveFileDialog1.Filter = "XML File |*.xml";
             saveFileDialog1.Title = "Save a XML File";
             saveFileDialog1.ShowDialog();
                doc.PreserveWhitespace = true;
                if (saveFileDialog1.FileName != "") { 
                    doc.Save(saveFileDialog1.FileName);}
                            
            }
            
        }
    }
}
