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

namespace lessonThree
{
 
    public partial class FileBrowser : Form
    {
       class  Form2:Form {
           public bool GotFiles;
           public TextBox pattern;
           public FolderBrowserDialog folder;
           public Button btn1;
           List<string> childlist;
           public Label lbn;
           string selectedPath;
           public Button close;
           FileBrowser parent1;
        public Form2(FileBrowser parent){
            GotFiles = false;
            parent1 = parent;
            pattern = new TextBox();
            this.Width=600;
            this.Height=400;
            lbn = new Label();
           lbn.SetBounds(10,10, 100,40);
            pattern.SetBounds(110,10,200,30);
            lbn.Text = "Введи фильтр";
            childlist = new List<string>();
            btn1 = new Button();
            btn1.SetBounds(50,120,100,40);
            folder = new FolderBrowserDialog();
            btn1.Click += new EventHandler(btn1_Click);
            this.Controls.Add(lbn);
            this.Controls.Add(btn1);
             this.Controls.Add(pattern);
             this.close = new Button();
             this.close.Click += new EventHandler(closebtn_Click);
             close.SetBounds(50, 170, 100, 40);
             this.Controls.Add(close);
             this.close.Text = "Закрыть";
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (this.GotFiles == true)
            {
                this.Close();

            }
            else {
                MessageBox.Show("Нет файлов по данной метке"); 
                this.Close();
            }
           
        }
           
        public List<string> ProcessDirectory(string targetDirectory)
        {
            List<string> flist=new List<string>();
            string[] searchPatterns;
            if (string.IsNullOrEmpty(pattern.Text) == false)
            {
                searchPatterns = pattern.Text.Split('|');

            }
            else {
                MessageBox.Show("Введите паттерн", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return flist;
            
            }
           foreach (string sp in searchPatterns){
         flist.AddRange(System.IO.Directory.GetFiles(targetDirectory, sp));
             childlist.Sort();
                           }
          return flist;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
           if (folder.ShowDialog()==DialogResult.OK){
               this.selectedPath = folder.SelectedPath;
        if(Directory.Exists(selectedPath)) 
            {
               
               childlist= ProcessDirectory(selectedPath);
               if (childlist.Count != 0) {
                   parent1.list.Items.AddRange(childlist.ToArray());
                   parent1 = null;
                   this.GotFiles = true;  
               }
            }
            else 
            {
                Console.WriteLine("{0} Не правильный файл или путь.", selectedPath);
            }        
           }
            
        }
        
        }


       public ListBox list;
        public Button openDialog;
        public List<string> files;
        Form2 myform = null;
        public event passfiles Form1Event;
        public  delegate void passfiles();
        public void chefiles() { 
        
        
        }
        public FileBrowser()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 600;
            files=new List<string>();
            list = new ListBox();
            list.SetBounds(10, 10, 200, 400);
            this.Controls.Add(list);
            openDialog = new Button();
            openDialog.Text = "Найди файлы";
            openDialog.SetBounds(100, 430, 100, 30);
            this.Controls.Add(openDialog);
            openDialog.Click += new EventHandler(openDialog_Click);
       
        }
       
        private void openDialog_Click(object sender, EventArgs e)
        {
            this.list.Items.Clear();
            this.list.Update();
            if (myform == null)
            {
                myform = new Form2(this);
                myform.Show();
            }
            else {
                myform.Close();
                myform = new Form2(this);
                myform.Show();
            }
            
        }

        
    }
}
