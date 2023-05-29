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
    public partial class SiparisOlusturForm : Form
    {
        decimal toplamTutar = 0;
        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>
        {
            new EkstraMalzeme {Ad ="Ketçap", Fiyat = 3 },
            new EkstraMalzeme { Ad = "Mayonez", Fiyat = 2.75m },
            new EkstraMalzeme { Ad = "Hardal", Fiyat = 3.25m },
            new EkstraMalzeme { Ad = "BBQ", Fiyat = 3.50m },
            new EkstraMalzeme { Ad = "Ranch", Fiyat = 2.75m },
            new EkstraMalzeme { Ad = "Buffalo", Fiyat = 4.00m },


        };
        public static List<Menu> menuler = new List<Menu>
        {
         new Menu{MenuAd = "Super King" , MenuFiyat =130},
         new Menu{MenuAd = "Super Quenn" , MenuFiyat =120},
         new Menu{MenuAd = "Mega Oueen" , MenuFiyat =155},
         new Menu{MenuAd = "Mega King" , MenuFiyat =120},
         new Menu{MenuAd = "Big King" , MenuFiyat =105},

        };
        public SiparisOlusturForm()
        {
            int y = 32;
            InitializeComponent();
            //form açıldığında ekstra malzemelerin gözükmesini istiyoruz.
            foreach (var item in ekstralar)
            {
                grbEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.Ad, Location = new Point { X = 26, Y = y }, AutoSize = false, AutoEllipsis = true, Width = 550, Tag = item });
                y = y + 25;
            }

            // form açıldğında tüm menüler combobox kısmına gelsin.
            cmbMenu.Items.AddRange(menuler.ToArray());
        }

        Siparis siparis;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            // siparis oluşturma formunda siparis ekle butonuna basıldığında yeni bir sipariş olusturulacak ve bilgileri listbox'a yazılacak.
            siparis = new Siparis();
            siparis.Menu = (Menu)cmbMenu.SelectedItem;
            siparis.Adet = (int)nudAdet.Value;
            if (rdbBuyuk.Checked)
                siparis.Boyut = Boyut.Buyuk;
            else if (rdbOrta.Checked)
                siparis.Boyut = Boyut.Orta;
            else if (rdbKucuk.Checked)
                siparis.Boyut = Boyut.Kucuk;
            else
                MessageBox.Show("Lütfen boyut seçiniz!");

            foreach (var item in grbEkstraMalzemeler.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    siparis.EkstraMalzemeler.Add((EkstraMalzeme)((CheckBox)item).Tag);  // siparişin ekstra malzemeleri listesine ekleme yapıyoruz. O yüzden siparis sınıfındaki listeyi de newlememiz gerekiyor. 
                }
            }

            toplamTutar += siparis.Hesapla();
            lblToplamTutar.Text = toplamTutar.ToString("c2");

            lstSiparisOzet.Items.Add(siparis);
            

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı : {toplamTutar} TL{Environment.NewLine}Siparişi onaylıyor musunuz?", "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstSiparisOzet.Items.Clear();
                siparisler.Add(siparis);

            }
            else
                MessageBox.Show("Sipariş Onaylanmadı.");
        }
    }
}
