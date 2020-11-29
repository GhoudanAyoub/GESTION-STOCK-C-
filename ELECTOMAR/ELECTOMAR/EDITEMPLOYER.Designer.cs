using System;
using System.Windows.Forms;

namespace ELECTOMAR
{
    partial class EDITEMPLOYER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDITEMPLOYER));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewrequest1 = new ELECTOMAR.viewrequest();
            this.home21 = new ELECTOMAR.home2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.viewrequest1);
            this.panel1.Controls.Add(this.home21);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 535);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(198, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 10);
            this.panel2.TabIndex = 41;
            // 
            // viewrequest1
            // 
            this.viewrequest1.BackColor = System.Drawing.SystemColors.Control;
            this.viewrequest1.Location = new System.Drawing.Point(198, 77);
            this.viewrequest1.Name = "viewrequest1";
            this.viewrequest1.Size = new System.Drawing.Size(978, 413);
            this.viewrequest1.TabIndex = 40;
            // 
            // home21
            // 
            this.home21.Location = new System.Drawing.Point(193, 77);
            this.home21.Name = "home21";
            this.home21.Size = new System.Drawing.Size(983, 413);
            this.home21.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.SidePanel1);
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button23);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 535);
            this.panel3.TabIndex = 38;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(5, 515);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 13);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © 2018 AYOUB GHOUDAN";
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.DarkRed;
            this.SidePanel1.Location = new System.Drawing.Point(3, 127);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(10, 59);
            this.SidePanel1.TabIndex = 39;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(12, 213);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(183, 54);
            this.button18.TabIndex = 15;
            this.button18.Text = "       les demandes";
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.Location = new System.Drawing.Point(12, 130);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(183, 54);
            this.button23.TabIndex = 13;
            this.button23.Text = "       Accueil ";
            this.button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(1143, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 23);
            this.button8.TabIndex = 37;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(518, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(382, 33);
            this.label17.TabIndex = 36;
            this.label17.Text = "GESTION DES EMPLOYES";
            // 
            // EDITEMPLOYER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EDITEMPLOYER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITEMPLOYER";
            this.Load += new System.EventHandler(this.EDITEMPLOYER_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button8;
        private Panel panel3;
        private Button button18;
        private Button button23;
        private Panel SidePanel1;
        private home2 home21;
        private viewrequest viewrequest1;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}