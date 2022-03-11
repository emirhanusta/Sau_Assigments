/****************************************************************************
*					    SAKARYA ÜNİVERSİTESİ
*				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
*				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
*		    	   NESNEYE DAYALI PROGRAMLAMA DERSİ
*					    2020-2021 BAHAR DÖNEMİ
*
*				ÖDEV NUMARASI..........: 1
*				ÖĞRENCİ ADI............: Emirhan Usta
*				ÖĞRENCİ NUMARASI.......: b201210023
*               DERSİN ALINDIĞI GRUP...: B
****************************************************************************/


using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] satrancTahtası = new int[8, 8];
            bool kaleVarMi = false;
            int x;
            int y;

            for (int i = 0; i < 8; i++)     //Tüm işlemleri 8 defa yaptıracak döngü
            {
                do  //Farklı rastgele konumları oluşturacak döngü
                {
                    kaleVarMi = false;
                    x = random.Next(0, 8);
                    y = random.Next(0, 8);

                    for (int j = 0; j < 8; j++)     //Oluşturulan rastgele sayıların kontrol edileceği döngü
                    {
                        if (satrancTahtası[j, y] != 0 || satrancTahtası[x, j] != 0)     //Oluşturulan rastgele sayıların bulumduğu satır ve sütunlar kontrol edildi
                        {
                            kaleVarMi = true;
                            break;
                        }
                    }
                } while (kaleVarMi);

                satrancTahtası[x, y] = 1;

                for (int j = 0; j < satrancTahtası.GetLength(0); j++)       //Dizinin son halini ekrana yazacak döngü
                {
                    for (int k = 0; k < satrancTahtası.GetLength(1); k++)
                    {
                        Console.Write(satrancTahtası[j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
