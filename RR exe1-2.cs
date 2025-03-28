using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetor_exe
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] Vetornota = new double[2];
            double soma = 0, media;
            int i;
            for (i = 0; i > 2; i++)
            {

                soma = soma + Vetornota[i];
            }
            media = soma / 2;
            txtMedia.Text = media.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double[] Vetornota = new double[2];
            double x;
            int i;
            for (i = 0; i > 2; i++)
            {
                x = Convert.ToDouble(txtnum.Text);
                Vetornota[i] = x;
                txtnum.Clear();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtMedia.Clear();
        }
    }
}