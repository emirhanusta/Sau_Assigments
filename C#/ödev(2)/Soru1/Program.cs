/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Emirhan Usta
**				ÖĞRENCİ NUMARASI.......: b201210023
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/


using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(new BenimString("Kim bilir, belki yarın, belki yarından da yakın,"));
            test.TestEt();
        }
    }
}
