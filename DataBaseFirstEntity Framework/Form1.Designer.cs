namespace libraryProjectEntity
{
    partial class Form1
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
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(120, 34);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(673, 20);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(468, 83);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(325, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(82, 83);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(275, 23);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Fill Tables";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFind);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFill;
    }
}

