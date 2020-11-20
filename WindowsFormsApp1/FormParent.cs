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
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEtudiant().Show();
        }

        private void listeEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.l.ShowDialog();
        }

        private void formEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEcole().Show();
        }

        private void listeEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.l2.ShowDialog();
        }
    }
}
