using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFactoryProvider
{
    
    
    public partial class Notepad : Form
    {
        ToolBar tBar;
        ImageList list;
        string exeFile;
        public RichTextBox text;
        TableLayoutPanel panel;
        ColorDialog ColorDialog1;
        FontDialog fontDialog1;
        OpenFileDialog f1;
        SaveFileDialog f2;
        bool isDirty;
        bool fileOpened;
        string selectedString;
        List<string> csharpwords;
       
        enum language { nolang, Csharp, html, css };
        language lan;
        public Notepad()
        {
            InitializeComponent();
              /*Component initialize code*/
            lan=language.nolang;
            //filling csharp list<string>...
            fillcsharp();
            #region
            f1 = new OpenFileDialog();
            f2 = new SaveFileDialog();
            this.Width = 600;
            this.Height = 500;
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorDialog1.AllowFullOpen = false;
            this.ColorDialog1.AnyColor = true;
            this.ColorDialog1.SolidColorOnly = false;
            this.ColorDialog1.ShowHelp = true;
            isDirty = true;
            fileOpened = false;
            
            // Associate the event-handling method with
            // the HelpRequest event.
            this.ColorDialog1.HelpRequest
                += new System.EventHandler(ColorDialog1_HelpRequest);
            panel = new TableLayoutPanel();
            panel.Location = new Point(0, 0);
            panel.SetBounds(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            panel.RowCount = 3;
            panel.ColumnCount = 1;
            
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            panel.Dock = DockStyle.Fill;
            #endregion

            list = new ImageList();
            list.ImageSize = new Size(50,50);
            /*File with images locate code*/
            #region
            exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
             string exeDir = Path.GetDirectoryName(exeFile);
             this.Text = exeDir.ToString();
             string fullPath = Path.Combine(exeDir, "..\\..\\Images\\");
            #endregion
             /*Images Code*/
             #region
             Image open = Image.FromFile(fullPath+"open.bmp");
            list.Images.Add(open);
            Image save = Image.FromFile(fullPath + "save.bmp");
            list.Images.Add(save);
            Image copy = Image.FromFile(fullPath +"copy.bmp");
            list.Images.Add(copy);
            Image cut = Image.FromFile(fullPath + "cut.bmp");
            list.Images.Add(cut);
            Image paste = Image.FromFile(fullPath +"paste.bmp");
            list.Images.Add(paste);
            Image delete = Image.FromFile(fullPath +"undo.bmp");
            list.Images.Add(delete);
            Image forcolor = Image.FromFile(fullPath + "fontcolor.bmp");
            list.Images.Add(forcolor);
            Image backcolor = Image.FromFile(fullPath + "paintbucket.bmp");
            list.Images.Add(backcolor);
            Image font = Image.FromFile(fullPath + "fonticon.bmp");
            list.Images.Add(font);
            Image comment = Image.FromFile(fullPath + "comment.png");
            list.Images.Add(comment);
            Image undocom = Image.FromFile(fullPath + "clearcom.png");
            list.Images.Add(undocom);
            tBar = new ToolBar();
            tBar.Size = new System.Drawing.Size(550, 50);
             #endregion
            /*  Tbar code*/
            #region
            tBar.ImageList = list;
            ToolBarButton toolbarButton1 = new ToolBarButton();
            ToolBarButton toolbarButton2 = new ToolBarButton();
            ToolBarButton toolbarButton3 = new ToolBarButton();
            ToolBarButton toolbarButton4 = new ToolBarButton();
            ToolBarButton toolbarButton5 = new ToolBarButton();
            ToolBarButton toolbarButton6 = new ToolBarButton();
            ToolBarButton toolbarButton7 = new ToolBarButton();
            ToolBarButton toolbarButton8 = new ToolBarButton();
            ToolBarButton toolbarButton9 = new ToolBarButton();
            ToolBarButton toolbarButton10 = new ToolBarButton();
            ToolBarButton toolbarButton11= new ToolBarButton();
            toolbarButton1.ImageIndex = 0;
             toolbarButton2.ImageIndex = 1;
                  toolbarButton3.ImageIndex = 2;
                       toolbarButton4.ImageIndex = 3;
                            toolbarButton5.ImageIndex = 4;
                            toolbarButton6.ImageIndex = 5;
                            toolbarButton7.ImageIndex = 6;
                            toolbarButton8.ImageIndex = 7;
                            toolbarButton9.ImageIndex = 8;
                            toolbarButton10.ImageIndex = 9;
                            toolbarButton11.ImageIndex = 10;
                            tBar.Buttons.Add(toolbarButton1);
                            tBar.Buttons.Add(toolbarButton2);
                            tBar.Buttons.Add(toolbarButton3);
                            tBar.Buttons.Add(toolbarButton4);
                            tBar.Buttons.Add(toolbarButton5);
                            tBar.Buttons.Add(toolbarButton6);
                            tBar.Buttons.Add(toolbarButton7);
                            tBar.Buttons.Add(toolbarButton8);
                            tBar.Buttons.Add(toolbarButton9);
                            tBar.Buttons.Add(toolbarButton10);
                            tBar.Buttons.Add(toolbarButton11);
                            tBar.Appearance = ToolBarAppearance.Flat;
                            tBar.BorderStyle = BorderStyle.Fixed3D;
                            tBar.ButtonClick += new ToolBarButtonClickEventHandler(tBar_ButtonClick);
                            this.Controls.Add(tBar);
            #endregion
            text = new RichTextBox();
            text.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            text.Dock = DockStyle.Fill;
            text.Multiline = true;
             text.ContextMenuStrip = this.contextMenuStrip1;
            text.BorderStyle = BorderStyle.FixedSingle;
            text.BackColor = System.Drawing.Color.Beige;
            text.ForeColor = System.Drawing.Color.Black;
            text.TextChanged += new EventHandler(text_TextChanged);
            text.KeyDown += new KeyEventHandler(tb_keyDown);
            /*FondDialog code*/
            #region
            fontDialog1 = new FontDialog();
                            fontDialog1.ShowColor = true;

                            fontDialog1.Font = text.Font;
                            fontDialog1.Color = text.ForeColor;
            #endregion

                            panel.Controls.Add(new Label() { Width=this.ClientRectangle.Width,
                            Height=20}, 0, 0);
                            panel.Controls.Add(tBar,1,0);
                            panel.Controls.Add(text,2,0);
                           //text.Dock = DockStyle.Fill;
                           
                            this.Controls.Add(panel);
                          
          

        }
        private void fillcsharp() {
            csharpwords = new List<string>();
            string[] words = new string[]{"abstract", "break", "char", "continue", "do", "event", "finally","foreach", "in", "is", "new", "out", "protected",
            "return", "sizeof", "struct", "true","ulong","volatile", "while", "using static", "unchecked", "try", "switch", "stackalloc", "sbyte", "public",
            "override", "null", "lock", "int", "goto", "fixed", "explicit", "double", "decimal", "checked", "byte", "as", "base", "case", "class", "default", "else", 
            "extern", "float", "if", "interface", "long", "bool", "catch", "const", "delegate", "enum", "false", "for", "implicit", "internal", "namespace", "operator", 
            "params", "private", "readonly", "ref", "sealed", "short", "static", "string", "this", "throw", "typeof", "unit", "unsafe", "ushort", "virtual", "void"};
            csharpwords.AddRange(words);
        
        }

        //below code for splitting the text into chunks by environment.newline
        private string[] splittext() {
            string currenttxt = this.text.Text;
            List<string> completewords = new List<string>();
            var words = currenttxt.Split(Environment.NewLine.ToCharArray(),
                             StringSplitOptions.None);
            foreach (var item in words) {
                var wbyline = item.Split(new char[] { ' ', ',', '\\', ')', '(', '/' , '#', '=', '.'}, StringSplitOptions.RemoveEmptyEntries);
                completewords.AddRange(wbyline);
            }
            return completewords.ToArray();
        }
        private void tb_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                string htmlword = "";
                string currentText = this.text.Text;
                char[] newlines=Environment.NewLine.ToCharArray();

                var words = splittext();
                #region
                if (lan == language.html && words.Length > 0)
                {
                    if (words.Length == 1)
                    {
                        htmlword = words[words.Length - 1];
                    }
                    else { htmlword = words[words.Length - 1]; }

                    Regex regex = new Regex("\\<[^\\>]*\\>");
                    Match m = regex.Match(htmlword);
                    if (m.Success)
                    {
                        text.SelectionStart = text.TextLength - htmlword.Length;
                        text.SelectionLength = htmlword.Length;
                        text.SelectionColor = Color.Red;
                    }
                    text.SelectionStart = text.TextLength + 1; text.SelectionLength = 0;
                    text.SelectionColor = Color.Black;



                }
                #endregion
                 if (lan == language.Csharp && words.Length > 0)
                {
                    if (words.Length == 1)
                    {
                        htmlword = words[words.Length - 1];
                    }
                    else { htmlword = words[words.Length - 1]; }

                   bool csharptrue=false;
                    foreach(string item in csharpwords){
                    if (string.Compare(htmlword, item)==0){
                        csharptrue = true;
                    
                    }
                    
                    }
                    
                    if (csharptrue)
                    {
                        text.SelectionStart = text.TextLength - htmlword.Length;
                        text.SelectionLength = htmlword.Length;
                        text.SelectionColor = Color.Red;
                    }
                    text.SelectionStart = text.TextLength + 1; text.SelectionLength = 0;
                    text.SelectionColor = Color.Black;
                    

                }
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            isDirty = true;
           
        }

        private void ColorDialog1_HelpRequest(object sender, System.EventArgs e)
        {

            MessageBox.Show("Пожалуйста выберите цвет нажав на него. "
                  + "Это изменит forecolor свойство шрифта.");
        }
        private void tBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            int indexSelect = 0;
                int lenthSelect=0;
            switch (e.Button.ImageIndex) { 
                case 0:
                   
                    if (f1.ShowDialog() == DialogResult.OK) {
                        StreamReader r = File.OpenText(f1.FileName);
                        text.Text = r.ReadToEnd();
                        r.Close();
                        fileOpened = true;
                        FileInfo file = new FileInfo(f1.FileName);
                        if (file.Extension == ".cs") {
                            findMenuItem();
                            findCsharp();
                        
                        }
                    }
                    break;
                case 1:
                    if (fileOpened == true)
                    {
                        StreamWriter w = new StreamWriter(f1.FileName);
                        w.WriteLine(text.Text);
                        w.Close();

                    }
                    else
                    {
                        if (f2.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter w = new StreamWriter(f2.FileName);
                            w.WriteLine(text.Text);
                            w.Close();


                        }
                    }
                   
                 
                    break;
                case 2:
                    if (text.SelectionLength > 0) {
                        text.Copy();
                    }
                    break;
                case 3:
                    if (text.SelectedText !="") { text.Cut(); }
                    break;
                case 4:
                    if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)==true)
                    {
                        text.SelectionStart = text.SelectionStart + text.SelectionLength;
                    }
                    text.Paste();
                    break;
                case 5:
                    if (text.CanUndo == true) {
                        text.Undo();
                        text.ClearUndo();
                    }
                    break;
                case 6:
                    DialogResult result = ColorDialog1.ShowDialog();
	                        if (result.Equals(DialogResult.OK))
	                        {
		                        text.ForeColor = ColorDialog1.Color;
	                        }
                    break;
                case 7:
                    DialogResult result1 = ColorDialog1.ShowDialog();
                    if (result1.Equals(DialogResult.OK))
                    {
                        text.BackColor = ColorDialog1.Color;
                    }
                    break;
                case 8:

                    if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                    {
                        text.Font = fontDialog1.Font;
                        text.ForeColor = fontDialog1.Color;
                    }
                    break;
                case 9:
                    if (lan == language.Csharp)
                    {
                            int len = text.SelectionLength;
                                                if (text.SelectionLength > 0)
                                                {
                                                    text.SelectionLength = 0;
                        

                                                    Clipboard.SetText("/*");

                                                    text.Paste();
                                                    text.SelectionLength = len;
                                                    text.SelectionStart = text.SelectionStart + len;
                                                    Clipboard.SetText("*/");
                                                    text.SelectionLength = 0;
                                                    text.Paste();
                                                   
                        
                                                }

                    }
                    else if (lan == language.html)
                    {

                        int len = text.SelectionLength;
                        if (text.SelectionLength > 0)
                        {
                            text.SelectionLength = 0;


                            Clipboard.SetText("<!--");

                            text.Paste();
                            text.SelectionLength = len;
                            text.SelectionStart = text.SelectionStart + len;
                            Clipboard.SetText("-->");
                            text.SelectionLength = 0;
                            text.Paste();


                        }


                    }
                    else if (lan == language.css)
                    {
                       
                    }
                    else { 
                     MessageBox.Show("No language selected");
                    }
                    
                    
                    break;
                case 10:
                    
                    indexSelect = text.SelectionStart;
                    lenthSelect=text.SelectionLength;
                    selectedString = text.SelectedText;
                    text.Cut();
                    Clipboard.Clear();
                    if (lan == language.Csharp)
                    {
                        if (selectedString.IndexOf("/*") != -1 && selectedString.LastIndexOf("*/") != -1)
                        {
                            selectedString = selectedString.Substring(selectedString.IndexOf("/*") + 2, selectedString.LastIndexOf("*/") - 2);
                            Clipboard.SetText(selectedString);
                            text.SelectionStart = indexSelect; text.SelectionLength = 0;
                            text.Paste();

                        }
                    }
                    if (lan == language.html) {

                        if (selectedString.IndexOf("<!--") != -1 && selectedString.LastIndexOf("-->") != -1)
                        {
                            selectedString = selectedString.Substring(selectedString.IndexOf("<!--") + 4, selectedString.LastIndexOf("-->") - 5);
                            Clipboard.SetText(selectedString);
                            text.SelectionStart = indexSelect; text.SelectionLength = 0;
                            text.Paste();

                        }
                    
                    }
                   
                    
                    

                    break;

            }
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = File.OpenText(f1.FileName);
                text.Text = r.ReadToEnd();
                r.Close();
                fileOpened = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileOpened == true) {
                StreamWriter w = new StreamWriter(f1.FileName);
                w.WriteLine(text.Text);
                w.Close();
            
            }
            else { if (f2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(f2.FileName);
                w.WriteLine(text.Text);
                w.Close();
                

            }
            }
            
          }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text.SelectedText != "") { text.Cut(); }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                text.SelectionStart = text.SelectionStart + text.SelectionLength;
            }
            text.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text.SelectionLength > 0)
            {
                text.Copy();
            }
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (text.CanUndo == true)
            {
                text.Undo();
                text.ClearUndo();
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ColorDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                text.ForeColor = ColorDialog1.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = ColorDialog1.ShowDialog();
            if (result1.Equals(DialogResult.OK))
            {
                text.BackColor = ColorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                text.Font = fontDialog1.Font;
                text.ForeColor = fontDialog1.Color;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text.SelectionLength == 0)
             
                text.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text.SelectionLength > 0)
            {
                text.Copy();
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (text.SelectedText != "") { text.Cut(); }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                text.SelectionStart = text.SelectionStart + text.SelectionLength;
            }
            text.Paste();
        }

        private void undoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (text.CanUndo == true)
            {
                text.Undo();
                text.ClearUndo();
            }
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {

                if (DialogResult.Yes != MessageBox.Show(

                    "Recent changes have not been saved. Close the application anyway?",

                    "Close Application?",

                     MessageBoxButtons.YesNo,

                     MessageBoxIcon.Question,

                     MessageBoxDefaultButton.Button2))
                {

                    e.Cancel = true;

                }
                else {

                    if (fileOpened == true)
                    {
                        StreamWriter w = new StreamWriter(f1.FileName);
                        w.WriteLine(text.Text);
                        w.Close();
                        
                    }
                    else
                    {
                        if (f2.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter w = new StreamWriter(f2.FileName);
                            w.WriteLine(text.Text);
                            w.Close();


                        }
                    }
                
                }

            }
            
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileOpened == true&&f1.FileName!="")
            {
                StreamWriter w = new StreamWriter(f1.FileName);
                w.WriteLine(text.Text);
                w.Close();
                fileOpened = false;
                text.Text = "";
            }
            else {
                if (DialogResult.Yes == MessageBox.Show(

                        "Файл не был открыт.Последние изменения не сохранены.Закрыть окно файла все равно?",

                        "Сохранить изменения?",

                         MessageBoxButtons.YesNo,

                         MessageBoxIcon.Question,

                         MessageBoxDefaultButton.Button2))
                {
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter w = new StreamWriter(f2.FileName);
                        w.WriteLine(text.Text);
                        w.Close();
                        text.Text = "";

                    }
                    

                }
            
            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            SearchBox searchbox = new SearchBox(this);
            searchbox.Show();


        }

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchAndReplace searchform = new searchAndReplace(this);
            searchform.Show();

        }
        //code for csharp text
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                lan = language.Csharp;
                if (item.Checked)
                {
                    if (text.Text.Length > 1)
                    {
                        findCsharp();
                    }

                }

            }
            else {
                lan = language.nolang;
            
            }
        }
        //code for html text
        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                lan = language.html;
                findHtml();

            }
            else
            {
                lan = language.nolang;

            }
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked) {
                lan = language.css;
            }
            else
            {
                lan = language.nolang;

            }

        }
        private void findMenuItem() {
            ToolStripMenuItem lanItem = (ToolStripMenuItem)menuStrip1.Items[3];
            for (int i = 0; i < lanItem.DropDown.Items.Count; i++) {
                if (String.Compare(lanItem.DropDown.Items[i].Tag.ToString(), "C#")==0) {

                    ToolStripMenuItem needitem = (ToolStripMenuItem)lanItem.DropDown.Items[i];
                    needitem.Checked = true;

                }
            
            
            }

        
        }

        /*
         This is code to unselect other menu items from toolstrip 
         */
        public void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

           
            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;

           
            selectedMenuItem.Owner.Show();
        }
        public void findHtml() {
            

            string txtinside = text.Text;
            
            Regex regex = new Regex("\\<[^\\>]*\\>");
            Match m = regex.Match(txtinside);
            while (m.ToString()!="") {
                m = regex.Match(txtinside);

                int index = text.Text.IndexOf(m.ToString());
                if ( index> 0)
                {
                    text.Select(index, m.ToString().Length);
                    text.SelectionColor = Color.Red;
                }
                                       
                txtinside = txtinside.Substring(txtinside.IndexOf(m.ToString())+m.ToString().Length);
            
            }
           
        }
        public void findCsharp() { 
        string txtinside = text.Text;
        int index = 0;
        var words = splittext();
        if (words.Length >0) {
            foreach (var word in words) {
                if (csharpwords.Contains(word)) {
                
                  index = text.Text.IndexOf(word, index);
                    
                               if ( index>= 0)
                            {
                                text.Select(index, word.Length);
                                text.SelectionColor = Color.Red;

                            }
                               index++;
                }
                
                        
                                          }
            
                          }

        
                }

           
        
        }
       
          
        
    
   
}

