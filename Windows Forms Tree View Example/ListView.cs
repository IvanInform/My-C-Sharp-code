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
using System.Reflection;

namespace lessons5_6
{
    public partial class ListViewProga : Form
    {
        ListView listView1;
        Button btn;
        GroupBox groupbox;
        RadioButton one;
        RadioButton two;
        RadioButton three;
        RadioButton four;
        RadioButton five;
        DirectoryInfo di;
        string exeFile;
        TextBox text;
        ImageList myImageList;
        ImageList imageListLarge;
        public ListViewProga()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 700;
            text = new TextBox();
            text.SetBounds(350, 300, 150, 30);
            this.Controls.Add(text);
            groupbox = new GroupBox();
            groupbox.Location = new Point(350, 100);
            groupbox.Size = new System.Drawing.Size(150, 150);
            groupbox.FlatStyle = FlatStyle.Flat;
            groupbox.Text = "Choose View";
             one = new RadioButton(); one.Text = "Details";
            one.Name = "Details";
            one.Location = new Point(355, 120);
            one.Size = new System.Drawing.Size(100, 20);
            one.UseVisualStyleBackColor = true;
            groupbox.Controls.Add(one);
            

            two = new RadioButton(); two.Text = "Icons";
            two.Location = new Point(355, 145);
            groupbox.Controls.Add(two);
            three = new RadioButton(); three.Text = "LargeIcon";
            three.Location = new Point(355, 170);
            groupbox.Controls.Add(three);
            four = new RadioButton(); four.Text = "SmallIcon";
            four.Location = new Point(355, 195);
            groupbox.Controls.Add(four);
            five = new RadioButton(); five.Text = "ListView";
            five.Location = new Point(355, 220);
            groupbox.Controls.Add(four);
            groupbox.Controls.Add(five);
            this.Controls.Add(one);
            this.Controls.Add(two);
            this.Controls.Add(three);
            this.Controls.Add(four);
            this.Controls.Add(five);
            this.Controls.Add(groupbox);
            btn = new Button();
            btn.SetBounds(350, 10, 100, 40);
            btn.Text = "View List";
            this.Controls.Add(btn);

           listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 600));

            this.Controls.Add(listView1);
            this.btn.Click += new EventHandler(btn_ClickEvent);
            this.imageListLarge = new ImageList();
        }
        
        private void btn_ClickEvent(object sender, EventArgs e)
        {
            this.di = new DirectoryInfo(text.Text);
            if (di.Exists)
            {
                if (one.Checked == true)
                {
                    ShowList(listView1, di);
                                      
                }
                if (two.Checked == true) {

                    ShowTiles(listView1, di);
                
                }
                if (three.Checked == true) {
                    ShowLargeImages(listView1, di);
                
                }
                if (four.Checked == true) {
                    ShowSmallImages(listView1, di);
                
                }
                if (five.Checked == true) {
                    ShowPureList(listView1, di);
                
                }
            }
            else {
                MessageBox.Show("The directory doesn't exist");
                return;
            }

        }

        private void ShowPureList(ListView view, DirectoryInfo di)
        {
            view.Items.Clear();
            view.LargeImageList = null;
            view.SmallImageList = null;
             view.View = View.List;
            
            view.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            view.FullRowSelect = true;
            // Display grid lines.
           
            view.Sorting = SortOrder.Ascending;
            
            foreach (FileInfo fi in di.GetFiles())
            {

                ListViewItem item = new ListViewItem(fi.Name, 0);
                item.SubItems.Add(fi.Length.ToString() + "bytes");
                item.SubItems.Add(fi.LastWriteTime.ToShortDateString());
                view.Items.Add(item);
            }
        }


        private void ShowTiles(ListView view, DirectoryInfo di)
        {
            view.Clear();
           view.View = View.Tile;

            // Initialize the tile size.
            view.TileSize = new Size(400, 45);
            myImageList = new ImageList();
            string path = this.FullPath();
            using (Icon myIcon = new Icon(path+"book.ico"))
            {
               
                    myImageList.Images.Add(myIcon);

                                    
            }
            myImageList.ImageSize = new Size(32, 32);
            view.LargeImageList = myImageList;
            view.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader(), new ColumnHeader() });
            foreach (FileInfo fi in di.GetFiles()) {
                ListViewItem item = new ListViewItem(new string[] 
            {fi.Name}, 0);
                view.Items.Add(item);
            }
        
        }
        private void ShowList(ListView view, DirectoryInfo di) {
            view.Items.Clear();
            view.View = View.Details;
            // Allow the user to edit item text.
            view.LabelEdit = true;
            // Allow the user to rearrange columns.
            view.AllowColumnReorder = true;
            // Display check boxes.
            view.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            view.FullRowSelect = true;
            // Display grid lines.
            view.GridLines = true;
            // Sort the items in the list in ascending order.
            view.Sorting = SortOrder.Ascending;
            view.Columns.Add("File Name", -2, HorizontalAlignment.Left);
            view.Columns.Add("Size", -2, HorizontalAlignment.Left);
            view.Columns.Add("Last Modified", -2, HorizontalAlignment.Left);
            foreach (FileInfo fi in di.GetFiles())
            {

                ListViewItem item = new ListViewItem(fi.Name, 0);
                item.SubItems.Add(fi.Length.ToString() + "bytes");
                item.SubItems.Add(fi.LastWriteTime.ToShortDateString());
                view.Items.Add(item);
            }
        
        }
        private string FullPath() {
            exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            this.Text = exeDir.ToString();
            string fullPath = Path.Combine(exeDir, "..\\..\\images\\");
            return fullPath;
        }

       
        private void ShowSmallImages(ListView view, DirectoryInfo di) {
            view.Items.Clear();
            view.View = View.SmallIcon;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };

            List<string> filesFound = new List<string>();
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(di.FullName, String.Format("*.{0}", filter), SearchOption.TopDirectoryOnly));
            }
            //imageListLarge.Images.Clear();
            ImageList imageListLarge = new ImageList();
            string path = this.FullPath();
            using (Icon myIcon = new Icon(path + "book.ico"))
            {

                imageListLarge.Images.Add(myIcon);


            }
            int index = 1;
            foreach (var file in filesFound)
            {
                Image img = Image.FromFile(file);
                imageListLarge.Images.Add(img);

                view.Items.Add(new ListViewItem(file.Substring(file.LastIndexOf('\\')), index++));
            }
            foreach (FileInfo fi in di.GetFiles())
            {
                if (filters.Contains(fi.Extension.Substring(fi.Extension.IndexOf(".") + 1)))
                {
                    continue;

                }
            ListViewItem item = new ListViewItem(new string[] { fi.Name }, 0);
            view.Items.Add(item);
                    
                
                
            }

            imageListLarge.ImageSize = new Size(32, 32);
            view.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader(), new ColumnHeader() });

            view.SmallImageList = imageListLarge;
        
        
        }
        private void ShowLargeImages(ListView view, DirectoryInfo di) {
            view.Items.Clear();
            view.View = View.LargeIcon;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            
            List<string> filesFound=new List<string>();
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(di.FullName, String.Format("*.{0}", filter), SearchOption.TopDirectoryOnly));
            }
            //imageListLarge.Images.Clear();
            ImageList imageListLarge = new ImageList();
            string path = this.FullPath();
            using (Icon myIcon = new Icon(path + "book.ico"))
            {

                imageListLarge.Images.Add(myIcon);


            }
            int index=1;
            foreach (var file in filesFound) {
                Image img = Image.FromFile(file);
                imageListLarge.Images.Add(img);

                view.Items.Add(new ListViewItem(file.Substring(file.LastIndexOf('\\')),index++));
            }
            foreach (FileInfo fi in di.GetFiles())
            {
                if (filters.Contains(fi.Extension.Substring(fi.Extension.IndexOf(".") + 1)))
                {
                    continue;

                }
                ListViewItem item = new ListViewItem(new string[] { fi.Name }, 0);
                view.Items.Add(item);



            }
            imageListLarge.ImageSize = new Size(50, 50);
            view.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader(), new ColumnHeader() });
           
            view.LargeImageList = imageListLarge;
        
        }

       
    }
}
