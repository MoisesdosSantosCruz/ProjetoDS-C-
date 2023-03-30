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
    public partial class frmcombus : Form
    {
        public frmcombus()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double quanti, total; 
            string tipo;
            
            quanti= Convert.ToDouble(txtquanti.Text);
            tipo = Convert.ToString(txttipo.Text);

            if (tipo.Equals("A"))
            {
                if (quanti <= 20)
                {
                    total = quanti * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = total.ToString();
                }
                else if (quanti > 20)
                {
                    total = quanti * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = total.ToString();
                }
            }
            if (tipo.Equals("G"))
            {
                if (quanti <= 20)
                {
                    total = quanti * (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = total.ToString();
                }
                else if (quanti > 20)
                {
                    total = quanti * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = total.ToString();
                }
                   
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtquanti.Clear();
            txttipo.Clear();
            txtresult.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
