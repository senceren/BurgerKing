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
    public partial class SiparisBilgileriForm : Form
    {
        public SiparisBilgileriForm()
        {
            InitializeComponent();
            // Siparis olusturma formunda yaptığımız siparişler listesini static yaptık ki dogrudan sınıf adıyla tüm siparislere erişebilelim.
            foreach(var item in SiparisOlusturForm.siparisler)
            {
                lstOnaylananlar.Items.Add(item);
            }
        }
    }
}
