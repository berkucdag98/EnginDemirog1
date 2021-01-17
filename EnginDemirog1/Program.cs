using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginDemirog1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("-----------------Metotlar------------------");

            //encapsulation --> ekle2 şeklindeki kullanım uygun değil buraya bir parametre eklendiğinde ekle2 yi çağırdığın tüm sayfaların patlar. O yüzden ekle metodu şeklindeki kullanım daha doğru.
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle2("Şeftali", "Bursa Şeftalisi", 10);
            sepet.Ekle2("Portakal", "Antalya Portakalı", 5);

            Console.ReadLine();

        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice