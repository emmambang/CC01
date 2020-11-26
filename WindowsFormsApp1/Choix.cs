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
                Preview p = new Preview();
                p.Show();

                Class1.temp2 = comboBox1.SelectedIndex;

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
    }
}
