using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerOrder
{
    public partial class Control3 : UserControl
    {
        public Control3()
        {
            InitializeComponent();
        }

        private void AdressSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adresiniz Başarıyla Kaydedildi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır, Bizi Tercih ettiğiniz için teşekkür ederiz");
        }
    }
}
