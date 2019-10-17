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
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            txtIncrementar.Text = i.ToString();
        }
     
        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            i++;
            txtIncrementar.Text = i.ToString();
        }

        private void txtIncrementar_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
