using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAkararmekanizmalariOdev_0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length >= 8)
            {
                MessageBox.Show("Onaylandı");
            }
            else if (txtSifre.Text.Length < 8)    
            {
                MessageBox.Show("Daha uzun bir şifre giriniz");
            }
           
            

            
        }
    }
}
