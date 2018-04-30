namespace FirstLesson
{
    partial class CreateStatic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CreateStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CreateStatic";
            this.Text = "CreateStatic";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateStatic_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CreateStatic_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CreateStatic_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateStatic_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateStatic_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}