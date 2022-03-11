using System;
using System.Collections.Generic;
using System.Text;

namespace Soru1
{
    class BenimString
    {
        public string Metin { get; set; }

        public BenimString(string metin)
        {
            this.Metin = metin;
            Console.WriteLine("String metin: " + Metin);
        }

        public int ElemanSayisi()
        {
            int sayac = 0;
            foreach (var item in Metin) //Metnin tüm karakterlerini dolaşıp sayaçı arrtırarak eleman sayısı bulunacak
            {
                sayac++;
            }
            return sayac;
        }

        public string Birlestir(string metin1, string metin2)
        {
            return (metin1 + " " + metin2);
        }

        public void ArayaGir(int index, string ek)
        {
            string metin = Metin;
            string yeniMetin = "";

            for (int i = 0; i < metin.Length; i++)  //Metnin tüm karakterlerini dolaşacak döngü
            {
                if (index != i)  //ekleme yapılacak indisi kontrol edecek if yapısı 
                {
                    yeniMetin += metin[i];
                }
                else
                {
                    yeniMetin += metin[i];
                    yeniMetin += ek;
                }
            }
            Console.WriteLine(yeniMetin);

        }

        public void DegerAl(int index, int uzunluk)
        {
            for (int i = index; i < index + uzunluk; i++)     //istenilen değer aralığını dolaşıp ekrana yazacak döngü
            {
                Console.Write(Metin[i]);
            }
            Console.WriteLine();
        }

        public void DiziyeAyir(char karakter)
        {
            int sayac = 0;
            for (int i = 0; i < Metin.Length; i++)  //Aranan karakterin metinde kaç tane olduğunu bulacak döngü
            {
                if (Metin[i] == karakter)
                {
                    sayac++;
                }
            }
            string[] dizi = new string[sayac];
            string yenimetin = "";
            int sayac2 = 0;
            for (int i = 0; i < Metin.Length; i++)     //Metnin tüm karakterlerini dolanacak döngü
            {
                if (Metin[i] != karakter)   //aranan karakteri kontrol edecek yapı
                {
                    yenimetin += Metin[i];
                }
                else
                {
                    dizi[sayac2] = yenimetin;
                    sayac2++;
                    yenimetin = "";
                }
            }
            foreach (var item in dizi)  //diziyi ekrana yazdıracak döngü
            {
                Console.WriteLine(item);
            }
        }

        public void CharDiziyeDonustur()
        {
            char[] dizi = new char[Metin.Length];
            for (int i = 0; i < Metin.Length; i++)  //Metnin tüm karakterlerini diziye atayacak ve ekrana yazacak döngü
            {
                dizi[i] = Metin[i];
                Console.Write(dizi[i]);
            }
            Console.WriteLine();
        }

        public void DegerIndis(string kelime)
        {
            Metin = Metin.ToLower();
            kelime = kelime.ToLower();
            int indis;
            for (int i = 0; i < Metin.Split().Length; i++)  //Metindeki tüm kelimeleri dolanacak döngü
            {
                if (kelime == Metin.Split()[i])   //Aranan kelimenin indisini bulacak yapı
                {
                    indis = Metin.IndexOf(Metin.Split()[i]);
                    Console.WriteLine(indis);
                    break;
                }
            }
        }

        public void SiralaAZ()
        {
            string[] dizi = new string[Metin.Split().Length];

            for (int i = 0; i < Metin.Split().Length; i++)  //Metinde ki tüm kelimeleri bir diziye aktaracak döngü
            {
                dizi[i] = Metin.Split()[i];
            }

            Array.Sort(dizi);
            Console.WriteLine("A-Z Sıralama:");

            foreach (string eleman in dizi) //Diziyi ekrana yazdıran döngü
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }

        public void SiralaZA()
        {
            string[] liste = new string[Metin.Split().Length];
            string isim;

            for (int i = 0; i < Metin.Split().Length; i++)  //Metinde ki tüm kelimeleri bir diziye aktaracak döngü
            {
                isim = Metin.Split()[i];
                liste[i] = isim;
            }

            Array.Sort(liste);
            Array.Reverse(liste);

            foreach (string eleman in liste)    //Diziyi ekrana yazdıran döngü
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }

        public void TersCevir()
        {
            for (int i = 0; i < Metin.Split().Length; i++)  //Metindeki tüm kelimeleri dolanacak döngü
            {
                string kelime = Metin.Split()[i];
                char[] dizi = new char[kelime.Length];
                for (int j = 0; j < kelime.Length; j++)     //Kelimeyi char diziye atayacak döngü
                {
                    dizi[j] = kelime[j];
                }

                Array.Reverse(dizi);
                foreach (var item in dizi)  //Diziyi ekrana yazdıran döngü
                {
                    Console.Write(item);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}
