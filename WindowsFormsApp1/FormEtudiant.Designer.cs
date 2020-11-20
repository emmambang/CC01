namespace WindowsFormsApp1
{
    partial class FormEtudiant
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblBarre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identifiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 166);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(287, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(486, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(757, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 63);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date de naissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(392, 56);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(318, 20);
            this.txtNom.TabIndex = 24;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(392, 180);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(318, 20);
            this.txtIdentifiant.TabIndex = 25;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(392, 114);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(318, 20);
            this.txtPrenom.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 290);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(392, 349);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(318, 20);
            this.txtContact.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPhoto);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 167);
            this.panel1.TabIndex = 29;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(51, 74);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(45, 17);
            this.lblPhoto.TabIndex = 50;
            this.lblPhoto.Text = "Photo";
            // 
            // lblBarre
            // 
            this.lblBarre.AutoSize = true;
            this.lblBarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarre.Location = new System.Drawing.Point(754, 393);
            this.lblBarre.Name = "lblBarre";
            this.lblBarre.Size = new System.Drawing.Size(79, 17);
            this.lblBarre.TabIndex = 51;
            this.lblBarre.Text = "Code barre";
            this.lblBarre.Visible = false;
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.lblBarre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEtudiant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtIdentifiant;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lblPhoto;
        public System.Windows.Forms.Label lblBarre;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

