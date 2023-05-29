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
    public partial class MenuEkleForm : Form
    {
        public MenuEkleForm()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); 
            menu.MenuAd= txtMenuAd.Text;
            menu.MenuFiyat = nudMenuFiyat.Value;

            SiparisOlusturForm.menuler.Add(menu);
            MessageBox.Show("Menü başarıyla eklenmiştir.");
        }
    }
}
