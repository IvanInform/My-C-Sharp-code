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
    public partial class layout : Form
    {
        class Phone {
            public int id { get; set; }
            public string Name { get; set; }
            public DateTime year { get; set; }
public Phone(int id, string name, DateTime year){
    this.id=id;
    this.Name=name;
    this.year=year;

}
            public Phone(){}
        }

        List<Phone> phones=new List<Phone>{
        new Phone{id=11, Name="Samsung", year=new DateTime(2017,10, 1)}, 
        new Phone {id =12, Name="Samsung Galaxy S4", year=new DateTime(2018,12,15)} 
        };
        public layout()
        {
            InitializeComponent();
            //FlowLayoutPanel panel = new FlowLayoutPanel();
            //panel.FlowDirection = FlowDirection.BottomUp;
            //List<Button> buttons = new List<Button>();
            //for (int i = 0; i < 5; i++) {
            //    buttons.Add( new Button { Size = new Size(40, 20) });
            //    panel.Controls.Add(buttons[i]);

            //}
            //this.Size = new System.Drawing.Size(500, 500);
            //panel.Location = new Point(10, 10);
            //panel.Size = new System.Drawing.Size(200,400);
            //panel.BorderStyle = BorderStyle.FixedSingle;
            //this.Controls.Add(panel);

            //SplitContainer cont = new SplitContainer();
            //cont.Size = new Size(300, 200);
            //cont.SplitterDistance = 100;
            //cont.SplitterIncrement = 10;
            //cont.Location = new Point(10, 10);
            //cont.BorderStyle = BorderStyle.Fixed3D;
            //cont.Cursor = Cursors.Cross;
            //this.Controls.Add(cont);
            //LinkLabel lbn = new LinkLabel();
            //lbn.Text = "Click me";
            //lbn.SetBounds(10, 10, 40, 20);
            //lbn.ActiveLinkColor = System.Drawing.Color.Red;
            //lbn.LinkColor = Color.Blue;
            //lbn.VisitedLinkColor = Color.Purple;
            
            //cont.Panel1.BackColor=Color.Beige;
            //cont.Panel2MinSize = 150;
            //cont.Panel1MinSize = 150;
            //cont.Panel1.Controls.Add(lbn);
            //cont.Panel2.Controls.Add(new Button
            //{
            //    Size = new Size(30, 20),
            //    Location = new Point(10, 10)
            //});

            //cont.Panel2.Controls.Add(new TextBox(){Location=new Point(10,40),
            //Size=new Size(50,100), Multiline=true,
            //ScrollBars=ScrollBars.Vertical});
               
            //this.Controls.Add(lbn);
            this.Height = 400;
            //ListBox list = new ListBox();
            //string[] array = new string[3] { "Brasil", "Spain", "India" };
            //list.Items.AddRange(array);
            //list.Location = new Point(10, 10);
            //list.Width = 200;
            //list.Height = 300;
            //list.SetSelected(2, true);
            //this.Controls.Add(list);
            ComboBox box = new ComboBox();
            box.Location = new Point(10, 10);
            box.Height = 200;
            box.Width = 100;
            box.DropDownStyle = ComboBoxStyle.DropDown;
            box.DropDownWidth = 200;
            box.DataSource=phones;
            box.DisplayMember="Name";
            box.ValueMember="id";
            this.Controls.Add(box);
            CheckedListBox checkbox1 = new CheckedListBox();
            checkbox1.Size = new Size(150, 150);
            checkbox1.Location = new Point(150, 10);
            checkbox1.Items.AddRange( new string[3]{"Brasil", "Argentina",
            "Urugvay"});
            checkbox1.SelectionMode = SelectionMode.One;
            this.Controls.Add(checkbox1);
            checkbox1.ItemCheck+=new ItemCheckEventHandler(checkbox_Checked );

        }

        private void checkbox_Checked(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            

            MessageBox.Show(box.SelectedItem.ToString());

        }
        
    }
}
