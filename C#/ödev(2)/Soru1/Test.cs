using System;
using System.Collections.Generic;
using System.Text;

namespace Soru1
{
    class Test
    {
        private BenimString benimString;
        public Test(BenimString benimString)
        {
            this.benimString = benimString;
        }
        public void TestEt()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Eleman sayısı: " + benimString.ElemanSayisi());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("String birleştirme: ");
            Console.WriteLine("Istiklal + Marşı =" + benimString.Birlestir("Istiklal", "Marşı"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Araya Gir: ");
            Console.WriteLine("10. indeks 'Korkma ': ");
            benimString.ArayaGir(10, "Korkma ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Değer Al: ");
            Console.WriteLine("0. indeksden başla 10 birim: ");
            benimString.DegerAl(0, 10);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Diziye Ayır: ");
            Console.WriteLine("Sting ifadeyi istenilen karakterlerden diziye ayırma: ");
            benimString.DiziyeAyir(',');
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Char Diziye Dönüştür:");
            benimString.CharDiziyeDonustur();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Değer İndis:");
            Console.WriteLine("Aranan Kelime 'belki' ");
            benimString.DegerIndis("belki");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("A dan Z ye Sıralama:");
            benimString.SiralaAZ();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Z den A ya Sıralama:");
            benimString.SiralaZA();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Dizideki Kelimeleri Ters Çevirme:");
            benimString.TersCevir();

        }
    }
}
