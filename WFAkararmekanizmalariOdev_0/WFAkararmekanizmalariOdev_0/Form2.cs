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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtNot.Text) > 100)
            {
                MessageBox.Show("100'den büyük not girilemez");
            }
            else if(Convert.ToInt32(txtNot.Text)<0)                 
            {
                MessageBox.Show("0'dan küçük bir not girilemez");
            }
            else
            {
                MessageBox.Show("Not girişi başarılı");
            }
        }
    }
}
