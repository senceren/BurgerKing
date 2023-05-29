using BurgerKingData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKing
{
    public partial class EkstraMalzemeEkleForm : Form
    {
        public EkstraMalzemeEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad = txtEkstraAd.Text;
            ekstraMalzeme.Fiyat = nudEkstraFiyat.Value;

            SiparisOlusturForm.ekstralar.Add(ekstraMalzeme);
            MessageBox.Show("Ekstra malzeme başarıyla eklenmiştir.");
        }
    }
}
