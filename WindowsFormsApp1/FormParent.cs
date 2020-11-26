using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Zen.Barcode;

namespace WindowsFormsApp1
{
    public partial class FormParent : Form
    {
        int i;

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormEtudiant f = new FormEtudiant();

            f.panel1.Visible = true;
            panel1.Controls.Add(f.panel1);
        }

        private void listeEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Class1.l.panel1.Visible = true;
            panel1.Controls.Add(Class1.l.panel1);
        }

        private void formEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormEcole f = new FormEcole();

            f.panel1.Visible = true;
            panel1.Controls.Add(f.panel1);
        }

        private void listeEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Class1.l2.panel1.Visible = true;
            panel1.Controls.Add(Class1.l2.panel1);
        }

        public FormParent()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Etudiant.json"))
            {
                CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    Class1.Tab1 = js.Deserialize<List<string[]>>(jr);

                    for(i = 0; i < Class1.Tab1.Count; i++)
                    {
                        Class1.l.listView1.Items.Add(new ListViewItem(Class1.Tab1[i]));
                        Class1.bte.Add((byte[])new ImageConverter().ConvertTo(barcode.Draw(Class1.Tab1[i][2],30), typeof(byte[])));
                    }
                }
            }

            using (StreamReader sr = new StreamReader(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Ecole.json"))
            {
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    Class1.Tab2 = js.Deserialize<List<string[]>>(jr);

                    for (i = 0; i < Class1.Tab2.Count; i++)
                    {
                        Class1.l2.listView1.Items.Add(new ListViewItem(Class1.Tab2[i]));
                        Class1.ch.comboBox1.Items.Add(Class1.Tab2[i][0]);
                    }
                }
            }
        }
    }
}
