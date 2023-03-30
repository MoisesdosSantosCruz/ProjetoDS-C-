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
    public partial class frmenquanto : Form
    {
        public frmenquanto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,num, result; 
            
            


                num = Convert.ToInt32(txtnum.Text);


            i = 1;
            while (i <= 10)
            {
                
                i++;
                result = num * i;
               
                txtresult.Text = String.Concat(txtresult.Text+ "\r\n" + result.ToString()); 
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void btncacular2_Click(object sender, EventArgs e)
        {
            int i, num,result;

            num = Convert.ToInt32(txtnum.Text);

            i = 1;

            do
            {
                i++;
                result = i * num;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + result.ToString());

            } while (i <= 10);



        }

        private void btncalcular3_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txtnum.Text);

            for (i = 1; i <= 10; i++)
            {
                result = i * num;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + result.ToString());
            }
        }
    }
}
