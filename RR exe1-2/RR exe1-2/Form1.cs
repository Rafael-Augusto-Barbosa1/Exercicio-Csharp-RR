using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_exe1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            int[] num= new int[15];
            int i, x;
            for (i = 0; i < 15; i++)
            {
                Random x = new Random();
                _ = num.next(10, 21);
            }
        }
    }
}
