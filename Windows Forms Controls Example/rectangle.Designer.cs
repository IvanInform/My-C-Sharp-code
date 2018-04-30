namespace FirstLesson
{
    partial class rectangle
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
            // rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Name = "rectangle";
            this.Text = "rectangle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rectangle_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}