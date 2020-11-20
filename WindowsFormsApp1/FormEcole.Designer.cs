namespace WindowsFormsApp1
{
    partial class FormEcole
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblBarre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(457, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(318, 20);
            this.txtNom.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(779, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 63);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(477, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 52);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(278, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 181);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date de creation";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(457, 200);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(318, 20);
            this.txtContact.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(457, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Contact";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPhoto);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 181);
            this.panel1.TabIndex = 48;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(69, 83);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(45, 17);
            this.lblPhoto.TabIndex = 49;
            this.lblPhoto.Text = "Photo";
            // 
            // lblBarre
            // 
            this.lblBarre.AutoSize = true;
            this.lblBarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarre.Location = new System.Drawing.Point(776, 341);
            this.lblBarre.Name = "lblBarre";
            this.lblBarre.Size = new System.Drawing.Size(79, 17);
            this.lblBarre.TabIndex = 50;
            this.lblBarre.Text = "Code barre";
            this.lblBarre.Visible = false;
            // 
            // FormEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 533);
            this.Controls.Add(this.lblBarre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormEcole";
            this.Text = "FormEcole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lblPhoto;
        public System.Windows.Forms.Label lblBarre;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}