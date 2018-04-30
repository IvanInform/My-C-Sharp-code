using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFactoryProvider
{
  
    public partial class GoodsForm : Form
    {
        List<Goods> myGoods = null;
        public GoodsForm()
        {
            InitializeComponent();
            myGoods = new List<Goods>() ;
            myGoods.Add(new Goods()
            {
                Name = "товар 1",
                Characteristics = "Характеристика1",
                Description = "Описание1",
                Price = 100
            });
            myGoods.Add(new Goods()
            {
                Name = "товар 2",
                Characteristics = "Характеристика2",
                Description = "Описание2",
                Price = 100
            });
            foreach (var item in myGoods) {
               comboBox1.Items.Add(item.ToString());
            } 
        }


        class form1 : Form {
            public Goods localgood = null;
            TextBox text1 = null;
            TextBox text2 = null;
            TextBox text3 = null;
            TextBox text4 = null;
            Button close1 = null;
            public form1(Goods mygood) {
                this.Width = 350;
                this.Height = 350;
                localgood = mygood;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.SetBounds(10, 10, 300, 300);
                text1 = new TextBox();
                text1.Width = 200;
                text1.Height = 30;
                text2 = new TextBox();
                text2.Width = 200;
                text2.Height = 30;
                text3 = new TextBox();
                text3.Width = 200;
                text3.Height = 30;
                text4 = new TextBox();
                text4.Width = 200;
                text4.Height = 30;
                panel.Controls.Add(text1);
                panel.Controls.Add(text2);
                panel.Controls.Add(text3);
                panel.Controls.Add(text4);
                text1.Text=localgood.Name;
                text2.Text = localgood.Characteristics;
                text3.Text = localgood.Description;
                text4.Text = Convert.ToString(localgood.Price);
                close1 = new Button();
                close1.Height = 30;
                close1.Width = 100;
                close1.Text = "Закрыть";
                panel.Controls.Add(close1);
        this.Controls.Add(panel);
               
                close1.Click += new EventHandler(close1_Click);
            }

            private void close1_Click(object sender, EventArgs e)
            {
                localgood = null;
                this.Close();
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box1 = (ComboBox)sender;
            bool isPresent=false;
            if (listBox1.Items.Count != 0)
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString().ToLower().CompareTo(box1.SelectedItem.ToString().ToLower()) == 0) { 
                        isPresent = true;
                    break; }
                 
                }
                if (isPresent == false)
                {
                    listBox1.Items.Add(box1.SelectedItem.ToString());

                }
                else
                {
                    MessageBox.Show("Этот товар выбран");
                }

            }
            else {
                listBox1.Items.Add(box1.SelectedItem.ToString());
            }
            char[] separator = new char[] { ';' };
            int sum=0;
            foreach (var litem in listBox1.Items) {
                string fromList = litem.ToString();
                string[] strItems = fromList.Split(separator);
                sum += Convert.ToInt32(strItems[3]);
                 
            }
            textBox1.Text = sum.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char [] separator=new char[]{';'};
            try
            {
                string fromList=listBox1.SelectedItem.ToString();
            string [] strItems=fromList.Split(separator);

            Goods g = new Goods()
            {
                Name = strItems[0],
                Characteristics = strItems[1],
                Description = strItems[2],
                Price = Convert.ToInt32(strItems[3])
            };
            form1 secondForm = new form1(g);
            secondForm.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Товар не выбран");
            }
            
        }

    }
    public class Goods
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}",Name, Characteristics,Description,Price);
        }
    }
}
