namespace ELECTOMAR
{
    partial class home2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SidePanel11 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.gestiondesemployes1 = new ELECTOMAR.gestiondesemployes();
            this.supprimeremploye1 = new ELECTOMAR.Supprimeremploye();
            this.recherchemploye1 = new ELECTOMAR.recherchemploye();
            this.modifieremploye1 = new ELECTOMAR.modifieremploye();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SidePanel11);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 413);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 54);
            this.button2.TabIndex = 44;
            this.button2.Text = "Modifier empolyé";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 54);
            this.button1.TabIndex = 43;
            this.button1.Text = "Rechercher empolyé";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SidePanel11
            // 
            this.SidePanel11.BackColor = System.Drawing.Color.DarkRed;
            this.SidePanel11.Location = new System.Drawing.Point(0, 41);
            this.SidePanel11.Name = "SidePanel11";
            this.SidePanel11.Size = new System.Drawing.Size(5, 51);
            this.SidePanel11.TabIndex = 42;
            // 
            // button31
            // 
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31.Location = new System.Drawing.Point(14, 135);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(183, 54);
            this.button31.TabIndex = 41;
            this.button31.Text = "Supprimer empolyé";
            this.button31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.Location = new System.Drawing.Point(17, 38);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(183, 54);
            this.button30.TabIndex = 40;
            this.button30.Text = "Ajouter empolyé";
            this.button30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // gestiondesemployes1
            // 
            this.gestiondesemployes1.Location = new System.Drawing.Point(206, 3);
            this.gestiondesemployes1.Name = "gestiondesemployes1";
            this.gestiondesemployes1.Size = new System.Drawing.Size(791, 410);
            this.gestiondesemployes1.TabIndex = 1;
            // 
            // supprimeremploye1
            // 
            this.supprimeremploye1.Location = new System.Drawing.Point(206, 3);
            this.supprimeremploye1.Name = "supprimeremploye1";
            this.supprimeremploye1.Size = new System.Drawing.Size(788, 410);
            this.supprimeremploye1.TabIndex = 2;
            // 
            // recherchemploye1
            // 
            this.recherchemploye1.Location = new System.Drawing.Point(206, 3);
            this.recherchemploye1.Name = "recherchemploye1";
            this.recherchemploye1.Size = new System.Drawing.Size(788, 410);
            this.recherchemploye1.TabIndex = 3;
            // 
            // modifieremploye1
            // 
            this.modifieremploye1.Location = new System.Drawing.Point(206, 3);
            this.modifieremploye1.Name = "modifieremploye1";
            this.modifieremploye1.Size = new System.Drawing.Size(788, 410);
            this.modifieremploye1.TabIndex = 4;
            // 
            // home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modifieremploye1);
            this.Controls.Add(this.recherchemploye1);
            this.Controls.Add(this.supprimeremploye1);
            this.Controls.Add(this.gestiondesemployes1);
            this.Controls.Add(this.panel1);
            this.Name = "home2";
            this.Size = new System.Drawing.Size(997, 413);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SidePanel11;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private gestiondesemployes gestiondesemployes1;
        private Supprimeremploye supprimeremploye1;
        private recherchemploye recherchemploye1;
        private modifieremploye modifieremploye1;
    }
}
