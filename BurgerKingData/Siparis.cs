using System.Text;

namespace BurgerKingData
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new();
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }
        public decimal SiparisFiyat { get; set; }

        public decimal Hesapla()
        {
            SiparisFiyat = 0;
            SiparisFiyat += Menu.MenuFiyat;

            if (Boyut == Boyut.Orta)
                SiparisFiyat += SiparisFiyat * 0.5m;
            else if (Boyut == Boyut.Buyuk)
                SiparisFiyat += SiparisFiyat * 0.75m;

            foreach(var item in EkstraMalzemeler)
            {
                SiparisFiyat += item.Fiyat;
            }

            SiparisFiyat = SiparisFiyat * Adet;

            return SiparisFiyat;
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine(Adet + " x " + Menu.MenuAd + " Menü " + Boyut + " Boy: " + SiparisFiyat.ToString("c2"));
            sb.AppendLine(" Ekstra Malzemeler: ");
            foreach(var item in EkstraMalzemeler)
                sb.AppendLine(item.Ad);
            return sb.ToString();
        }
    }
}