using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Choix : Form
    {
        public Choix()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int i;

                for (i = 0; i < Class1.Tab2.Count; i++)
                {
                    if (Class1.Tab2[i][0] == comboBox1.Text)
                    {
                        Class1.temp2 = i;
                    }
                }
                Preview p = new Preview();
                p.Show();

                this.Close();
            }

            else
            {
                MessageBox.Show
                    (
                        "Vous n'avez sélectionné aucune école",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void Choix_Load(object sender, EventArgs e)
        {

        }
    }
}
