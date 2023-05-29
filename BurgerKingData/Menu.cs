using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingData
{
    public class Menu
    {
        public string MenuAd{ get; set; }
        public decimal MenuFiyat { get; set; }

        public override string ToString()
        {
            return MenuAd + " " + MenuFiyat.ToString("c2");
        }
    }
}
