namespace ELECTOMAR
{
    partial class firstCustomControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstCustomControl1));
            this.SlidePic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SlidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // SlidePic
            // 
            this.SlidePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlidePic.Image = ((System.Drawing.Image)(resources.GetObject("SlidePic.Image")));
            this.SlidePic.Location = new System.Drawing.Point(0, 0);
            this.SlidePic.Name = "SlidePic";
            this.SlidePic.Size = new System.Drawing.Size(940, 521);
            this.SlidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlidePic.TabIndex = 0;
            this.SlidePic.TabStop = false;
            this.SlidePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // firstCustomControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SlidePic);
            this.Name = "firstCustomControl1";
            this.Size = new System.Drawing.Size(940, 521);
            ((System.ComponentModel.ISupportInitialize)(this.SlidePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SlidePic;
        private System.Windows.Forms.Timer timer1;
    }
}
