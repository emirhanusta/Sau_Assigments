/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Emirhan Usta
**				ÖĞRENCİ NUMARASI.......: b201210023
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/

using System;

namespace Soru2
{
    class Program
    {

        static void Main(string[] args)
        {

            void Secim1()
            {
                //substring kullanmadan bulma

                Console.Write("Karakter Dizini: ");
                string metin = Console.ReadLine();       //Kontrol edilecek karakter dizini kullanıcıdan alındı
                metin = metin.ToLower();

                Console.Write("Aranacak Kelime: ");
                string arananKelime = Console.ReadLine();    //Kontrol edilecek kelime kullanıcıdan alındı
                arananKelime = arananKelime.ToLower();

                int aranilacakYer = 0;

                for (int i = 0; i < metin.Split().Length; i++)  //Girilen tüm kelimeleri kontrol edecek döngü
                {
                    if (arananKelime == metin.Split()[i])   //Aranan kelime varsa bulunduğu indisi ekrana yazacak  
                    {
                        Console.WriteLine("kelime '" + arananKelime + "' indis: " + metin.IndexOf(arananKelime, aranilacakYer));    //indis ve kelime ekrana yazıldı
                        aranilacakYer = metin.IndexOf(arananKelime, aranilacakYer) + arananKelime.Length;   //Aramaya başlanacak yer güncellendi 

                    }
                }

            }

            void Secim2()
            {
                //substring kullanarak bulma

                Console.Write("Karakter Dizini: ");
                string metin = Console.ReadLine();       //Kontrol edilecek karakter dizini kullanıcıdan alındı
                metin = metin.ToLower();

                Console.Write("Aranacak Kelime: ");
                string arananKelime = Console.ReadLine();       //Kontrol edilecek kelime kullanıcıdan alındı
                arananKelime = arananKelime.ToLower();
                int aranilacakYer = 0;

                for (int i = 0; i < metin.Length - arananKelime.Length; i++)  //Girilen metni harf harf kontrol edecek döngü
                {
                    if (arananKelime == metin.Substring(i, arananKelime.Length))    //Substring kullanarak aranan kelimenin olup plmadığı kontrol edildi
                    {
                        Console.WriteLine("kelime '" + arananKelime + "' indis: " + metin.IndexOf(arananKelime, aranilacakYer));    //indis ve kelime ekrana yazıldı
                        aranilacakYer = metin.IndexOf(arananKelime, aranilacakYer) + arananKelime.Length;               //Aramaya başlanacak yer güncellendi 

                    }
                }

            }

            void Secim3()
            {
                //harfleri bulma

                int sayac = 0;
                string cumle;
                string harfler = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ";
                char harf;
                Console.WriteLine("Karakter dizini: ");
                cumle = Console.ReadLine();
                cumle = cumle.ToUpper();

                Console.WriteLine();


                for (int i = 0; i < harfler.Length; i++)    //Tüm harfleri döndürecek döngü
                {
                    harf = harfler[i];
                    sayac = 0;
                    for (int j = 0; j < cumle.Length; j++)  //Cümlenin tüm harflerini döndürecek döngü
                    {
                        if (harf == cumle[j])       //Kontrol edilen harf ile cünledeki harfleri karşılaştırıldı
                        {
                            sayac++;
                        }
                    }
                    Console.Write(harfler[i] + "  Harfinden  " + sayac + "  tane  ");

                    for (int k = 0; k < sayac; k++)     //Kontrol edilen harften kaç tane varsa ekranda '*' olarak gösterildi
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            int secim;

            do      //Menüyü ekrana yazacak ve geçerli bir seçim yapılana kadar tekrarlanacak döngü
            {
                Console.WriteLine("Menü");
                Console.WriteLine("1-String bir değişkende, substring kullanmadan ara");
                Console.WriteLine("2-String bir değişkende, substring kullanarak ara");
                Console.WriteLine("3-Alfabenin karakterlerinin string ifadede kaç kez geçtiğini bul ve çiz");
                Console.WriteLine("4-Çıkış");

                Console.Write("Seçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (!(secim == 1 || secim == 2 || secim == 3 || secim == 4));

            //Seçilen işleme ait fonksiyon çağırıldı
            if (secim == 1)
            {
                Console.WriteLine("Seçiminiz: \n String bir değişkende, subsitring kullanmadan ara");

                Secim1();
            }
            else if (secim == 2)
            {
                Console.WriteLine("Seçiminiz: \n String bir değişkende, subsitring kullanarak ara");

                Secim2();
            }
            else if (secim == 3)
            {
                Console.WriteLine("Seçiminiz: \n Alfabenin karakterlerinin string ifadede kaç kez geçtiğini bul ve çiz");

                Secim3();
            }
            else
            {
                Console.WriteLine("Çıkış yapıldı");
            }

        }
    }
}
