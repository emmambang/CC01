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
            this.txtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // txtNom
            // 
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.HintForeColor = System.Drawing.Color.Empty;
            this.txtNom.HintText = "";
            this.txtNom.isPassword = false;
            this.txtNom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNom.LineIdleColor = System.Drawing.Color.White;
            this.txtNom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNom.LineThickness = 2;
            this.txtNom.Location = new System.Drawing.Point(377, 43);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(249, 33);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrenom.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrenom.HintText = "";
            this.txtPrenom.isPassword = false;
            this.txtPrenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrenom.LineIdleColor = System.Drawing.Color.White;
            this.txtPrenom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrenom.LineThickness = 2;
            this.txtPrenom.Location = new System.Drawing.Point(377, 103);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(249, 33);
            this.txtPrenom.TabIndex = 5;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // txtIdentifiant
            // 
            this.txtIdentifiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentifiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdentifiant.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdentifiant.HintText = "";
            this.txtIdentifiant.isPassword = false;
            this.txtIdentifiant.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIdentifiant.LineIdleColor = System.Drawing.Color.White;
            this.txtIdentifiant.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIdentifiant.LineThickness = 2;
            this.txtIdentifiant.Location = new System.Drawing.Point(377, 169);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(249, 33);
            this.txtIdentifiant.TabIndex = 7;
            this.txtIdentifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail.HintText = "";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMail.LineIdleColor = System.Drawing.Color.White;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMail.LineThickness = 2;
            this.txtMail.Location = new System.Drawing.Point(377, 279);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(249, 33);
            this.txtMail.TabIndex = 9;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Empty;
            this.txtContact.HintText = "";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContact.LineIdleColor = System.Drawing.Color.White;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContact.LineThickness = 2;
            this.txtContact.Location = new System.Drawing.Point(377, 338);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(249, 33);
            this.txtContact.TabIndex = 11;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.pictureBox4.Location = new System.Drawing.Point(12, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 166);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(286, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(485, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(754, 383);
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
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(863, 514);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Name = "FormEtudiant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrenom;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdentifiant;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

