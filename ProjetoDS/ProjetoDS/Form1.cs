using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcombus fm = new frmcombus();
            fm.Show();
        }

        private void exercícioEnquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmenquanto fm = new frmenquanto();
            fm.Show();
        }

        private void mnusair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
