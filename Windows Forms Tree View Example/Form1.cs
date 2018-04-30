using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessons5_6
{
    public partial class Form1 : Form
    {
        TreeView tree;
        //ImageList galery;
         string exeFile;
        TreeNode node1;
        //OpenFileDialog fileopen;
        Button btn;
        string dirname;
        DirectoryInfo di = null;
        TreeNode rootnode = null;
        TextBox box;
        public Form1()
        {
            InitializeComponent();
            box = new TextBox();
            box.SetBounds(350, 100, 100, 30);
            this.Controls.Add(box);
            //fileopen = new OpenFileDialog();
            btn = new Button();
            btn.SetBounds(350, 10, 100, 40);
            btn.Text = "Open Directory";
            btn.Click += new EventHandler(btn_ClickEvent);
            this.Controls.Add(btn);
            this.Width = 700;
            this.Height = 500;
            tree = new TreeView();
            this.Controls.Add(tree);
            tree.SetBounds(10, 10, 300, 600);
            //TreeNode tn = new TreeNode("New node");
            //tree.Nodes.Add(tn);
            exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
             string exeDir = Path.GetDirectoryName(exeFile);
             this.Text = exeDir.ToString();
             string fullPath = Path.Combine(exeDir, "..\\..\\images\\");
            try
{


}
catch (Exception ex)
{
MessageBox.Show(ex.Message);
}

        }

        private void btn_ClickEvent(object sender, EventArgs e)
        {

            if (box.Text!="") {
                dirname = box.Text;
                di = new DirectoryInfo(dirname);
                int index = dirname.LastIndexOf('/');
                string file=null;
                if (index != -1)
                {
                    file = dirname.Substring(index);
                }
                else {
                    file = dirname;
                }
                    rootnode = new TreeNode(file);
                    tree.Nodes.Add(rootnode);

                    fillTreeView(rootnode, di);
                
            }

        }
        private void fillTreeView(TreeNode node, DirectoryInfo dirs) {
            if (!dirs.Exists){
                return;
            }
           foreach (FileInfo fi in dirs.GetFiles()) {
                node.Nodes.Add(new TreeNode(fi.Name));
            
                        }
            foreach (DirectoryInfo subdir in dirs.GetDirectories()) {
                
                TreeNode nextnode=new TreeNode(subdir.Name);
                    node.Nodes.Add(nextnode);

                    fillTreeView(nextnode, subdir);
                
            
            }
            


        }
    }
}
