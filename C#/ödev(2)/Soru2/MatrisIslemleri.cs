using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    static class MatrisIslemleri
    {
        public static void Toplama(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i <= a.GetUpperBound(0); i++)     //İki boyutlu dizileri dolanıp toplama işlemini yapacak döngü
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }

        public static void Carpma(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i <= a.GetUpperBound(0); i++)   //İki boyutlu dizileri dolanıp çarpma işlemini yapacak döngü
            {
                for (int j = 0; j <= b.GetUpperBound(1); j++)
                {
                    int toplam = 0;
                    for (int k = 0; k <= a.GetUpperBound(1); k++)
                    {
                        toplam += a[i, k] * b[k, j];
                    }
                    c[i, j] = toplam;
                }
            }
        }

        public static void TersAl(int[,] a, double[,] b)
        {
            double temp1 = 1, temp2 = 1, determinant = 0;

            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (i == j) //  0x0 ve 1x1 ise girsin
                    {
                        temp1 *= a[i, j]; // 
                    }
                    else //  0x1 ve 1x0 ise girsin
                    {
                        temp2 *= a[i, j];
                    }
                }
            }
            determinant = temp1 - temp2;

                //Tersini alma işlememi
                for (int i = 0; i <= b.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= b.GetUpperBound(1); j++)
                    {
                        if (i == j)
                        {
                            //burada yaptıgım işlem 0x0 geliyor ben tersine  1x1 atıyorum 
                            //eğer 1x1 gelirse 0x0 atamıs yanı yer değiştirmis oldum
                            b[b.GetUpperBound(0) - i, b.GetUpperBound(1) - i] = a[i, j];
                            b[b.GetUpperBound(0) - i, b.GetUpperBound(1) - i] = b[b.GetUpperBound(0) - i, b.GetUpperBound(1) - i] / determinant;
                        }
                        else if (i != j)
                        {
                            b[i, j] = (-a[i, j]);//- işareti formülden geliyor
                            b[i, j] = b[i, j] / determinant;
                        }
                    }
                }
            
        }

        public static void Transpoz(int[,] a, int[,] b)
        {
            for (int i = 0; i <= a.GetUpperBound(0); i++) //İki boyutlu dizileri dolanıp transpoz alma işlemini yapacak döngü
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    b[i, j] = a[j, i];
                }
            }
        }

        public static int IzBul(int[,] a)
        {
            int toplam = 0;

            for (int i = 0; i <= a.GetUpperBound(0); i++)   //İki boyutlu dizileri dolanıp iz alma işlemini yapacak döngü
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (i==j) //Sadece köşegen üzerindeki sayılar toplanacak
                    {
                        toplam += a[i, j];
                    }
                }
            }

            return toplam;
        }

        public static void TekliMatrisYaz(int[,] a, double[,] b,string islem)
        {
            TextWriter tw = new StreamWriter("Matris.txt");
            tw.Write("");
            tw.Close();


            FileStream fs = new FileStream("Matris.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("MATRİS:");
            for (int i = 0; i < 2; i++) //Matrisin işlem yapılmamış hali yazıldı
            {
                    for (int j = 0; j < 2; j++)
                    {
                        sw.Write(a[i, j] + " ");
                    }
                    sw.WriteLine();
            }
            sw.WriteLine();
            sw.WriteLine("İşlem: " + islem);     //Yapılan işlem yazıldı
            sw.WriteLine();
            sw.WriteLine("SONUÇ");
            for (int i = 0; i < 2; i++) //Matrisin işlem yapılmış hali yazıldı
            {
                    for (int j = 0; j < 2; j++)
                    {
                        sw.Write((float)(b[i, j]) + " ");
                    }
                    sw.WriteLine();
            }

            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();            
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.


        }

        public static void TekliMatrisYazIz(int[,] a,string islem, int _iz)
        {
            TextWriter tw = new StreamWriter("Matris.txt");
            tw.Write("");
            tw.Close();

            FileStream fs = new FileStream("Matris.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("MATRİS:");    //Matrisin işlem yapılmamış hali yazıldı
            for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        sw.Write(a[i, j] + " ");
                    }
                    sw.WriteLine();
            }
            sw.WriteLine();
            sw.WriteLine("İşlem: " + islem);    //Yapılan işlem yazıldı
            sw.WriteLine();
            sw.WriteLine("SONUÇ: "+_iz);    //Matrisin işlem yapılmış hali yazıldı

            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }
        
        public static void IkiliMatrisYaz(int[,] a, int[,] b, int[,] c,string islem)
        {
            TextWriter tw = new StreamWriter("Matris.txt");
            tw.Write("");
            tw.Close();


            FileStream fs = new FileStream("Matris.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("1.Matris: ");
            for (int i = 0; i < 2; i++) //İlk matrisin işlem yapılmamış hali yazıldı
            {
                for (int j = 0; j < 2; j++)
                {
                    sw.Write(a[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.WriteLine();
            sw.WriteLine("2.Matris: ");
            for (int i = 0; i < 2; i++) //İkinci matrisin işlem yapılmamış hali yazıldı
            {
                for (int j = 0; j < 2; j++)
                {
                    sw.Write(b[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.WriteLine();
            sw.WriteLine("İşlem: " + islem);    //Yapılan işlem yazıldı
            sw.WriteLine();
            sw.WriteLine("Sonuç: ");
            for (int i = 0; i < 2; i++) //Sonuç Yazıldı
            {
                for (int j = 0; j < 2; j++)
                {
                    sw.Write(c[i, j] + " ");
                }
                sw.WriteLine();
            }

            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }

    }
}
