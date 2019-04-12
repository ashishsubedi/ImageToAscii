namespace ImageToAscii
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
            this.data = new System.Windows.Forms.RichTextBox();
            this.opnBtn = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.convertBtn = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(1, 130);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(621, 575);
            this.data.TabIndex = 0;
            this.data.Text = "";
            // 
            // opnBtn
            // 
            this.opnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opnBtn.Location = new System.Drawing.Point(19, 33);
            this.opnBtn.Name = "opnBtn";
            this.opnBtn.Size = new System.Drawing.Size(105, 29);
            this.opnBtn.TabIndex = 1;
            this.opnBtn.Text = "Open";
            this.opnBtn.UseVisualStyleBackColor = true;
            this.opnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // convertBtn
            // 
            this.convertBtn.Enabled = false;
            this.convertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.convertBtn.Location = new System.Drawing.Point(157, 33);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(105, 29);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(19, 69);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 13);
            this.path.TabIndex = 3;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.Location = new System.Drawing.Point(282, 33);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 29);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(19, 68);
            this.trackBar.Maximum = 400;
            this.trackBar.Minimum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(368, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 754);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.save);
            this.Controls.Add(this.path);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.opnBtn);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Image to Ascii";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox data;
        private System.Windows.Forms.Button opnBtn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

