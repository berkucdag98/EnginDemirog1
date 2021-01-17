using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginDemirog1
{
    class SepetManager
    {
        
        public void Ekle(Product urun)
        {
            Console.WriteLine("Ürün Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Ürün Sepete Eklendi : " + urunAdi);
        }
    }
}
