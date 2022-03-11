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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string _islem = "";

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            _islem = "Toplama";
            int[,] dizi1 = { { Convert.ToInt32(numericUpDown_0x0.Value),
                    Convert.ToInt32(numericUpDown_0x1.Value) },
                    { Convert.ToInt32(numericUpDown_1x0.Value),
                    Convert.ToInt32(numericUpDown_1x1.Value) } };

            int[,] dizi2 = { { Convert.ToInt32(numericUpDown2_0x0.Value),
                    Convert.ToInt32(numericUpDown2_0x1.Value) },
                    { Convert.ToInt32(numericUpDown2_1x0.Value),
                    Convert.ToInt32(numericUpDown2_1x1.Value) } };

            int[,] dizi = new int[2, 2];

            MatrisIslemleri.Toplama(dizi1, dizi2, dizi);

            lblIkili_0x0.Text = Convert.ToString(dizi[0, 0]);
            lblIkili_0x1.Text = Convert.ToString(dizi[0, 1]);
            lblIkili_1x0.Text = Convert.ToString(dizi[1, 0]);
            lblIkili_1x1.Text = Convert.ToString(dizi[1, 1]);

        }

        private void BtnCarpma_Click(object sender, EventArgs e)
        {
            _islem = "Çarpma";

            int[,] dizi1 = { { Convert.ToInt32(numericUpDown_0x0.Value),
                    Convert.ToInt32(numericUpDown_0x1.Value) },
                    { Convert.ToInt32(numericUpDown_1x0.Value),
                    Convert.ToInt32(numericUpDown_1x1.Value) } };

            int[,] dizi2 = { { Convert.ToInt32(numericUpDown2_0x0.Value),
                    Convert.ToInt32(numericUpDown2_0x1.Value) },
                    { Convert.ToInt32(numericUpDown2_1x0.Value),
                    Convert.ToInt32(numericUpDown2_1x1.Value) } };

            int[,] dizi = new int[2, 2];

            MatrisIslemleri.Carpma(dizi1, dizi2, dizi);

            lblIkili_0x0.Text = Convert.ToString(dizi[0, 0]);
            lblIkili_0x1.Text = Convert.ToString(dizi[0, 1]);
            lblIkili_1x0.Text = Convert.ToString(dizi[1, 0]);
            lblIkili_1x1.Text = Convert.ToString(dizi[1, 1]);

        }

        private void BtnTersAL_Click(object sender, EventArgs e)
        {
            _islem = "Ters Alma";

            int[,] dizi = { { Convert.ToInt32(numericUpDownTek_0x0.Value),
                    Convert.ToInt32(numericUpDownTek_0x1.Value) },
                    { Convert.ToInt32(numericUpDownTek_1x0.Value),
                    Convert.ToInt32(numericUpDownTek_1x1.Value) } };

            double[,] dizi2 = new double[2, 2];

            MatrisIslemleri.TersAl(dizi, dizi2);

            lblTekli_0x0.Text = Convert.ToString(dizi2[0, 0]);
            lblTekli_0x1.Text = Convert.ToString(dizi2[0, 1]);
            lblTekli_1x0.Text = Convert.ToString(dizi2[1, 0]);
            lblTekli_1x1.Text = Convert.ToString(dizi2[1, 1]);
        }

        private void BtnTranspoze_Click(object sender, EventArgs e)
        {
            _islem = "Transpoze";

            int[,] dizi = { { Convert.ToInt32(numericUpDownTek_0x0.Value),
                    Convert.ToInt32(numericUpDownTek_0x1.Value) },
                    { Convert.ToInt32(numericUpDownTek_1x0.Value),
                    Convert.ToInt32(numericUpDownTek_1x1.Value) } };

            int[,] dizi2 = new int[2, 2];

            MatrisIslemleri.Transpoz(dizi, dizi2);

            lblTekli_0x0.Text = Convert.ToString(dizi2[0, 0]);
            lblTekli_0x1.Text = Convert.ToString(dizi2[0, 1]);
            lblTekli_1x0.Text = Convert.ToString(dizi2[1, 0]);
            lblTekli_1x1.Text = Convert.ToString(dizi2[1, 1]);

        }

        private void BtnIzBul_Click(object sender, EventArgs e)
        {
            _islem = "İz Bulma";

            int[,] dizi = { { Convert.ToInt32(numericUpDownTek_0x0.Value),
                    Convert.ToInt32(numericUpDownTek_0x1.Value) },
                    { Convert.ToInt32(numericUpDownTek_1x0.Value),
                    Convert.ToInt32(numericUpDownTek_1x1.Value) } };

            lbl_iz.Text = Convert.ToString(MatrisIslemleri.IzBul(dizi));

        }

        private void BtnYaz_Ikili_Click(object sender, EventArgs e)
        {
            int[,] dizi1 = { { Convert.ToInt32(numericUpDown_0x0.Value),
                    Convert.ToInt32(numericUpDown_0x1.Value) },
                    { Convert.ToInt32(numericUpDown_1x0.Value),
                    Convert.ToInt32(numericUpDown_1x1.Value) } };

            int[,] dizi2 = { { Convert.ToInt32(numericUpDown2_0x0.Value),
                    Convert.ToInt32(numericUpDown2_0x1.Value) },
                    { Convert.ToInt32(numericUpDown2_1x0.Value),
                    Convert.ToInt32(numericUpDown2_1x1.Value) } };

            int[,] dizi = { {Convert.ToInt32(lblIkili_0x0.Text), Convert.ToInt32(lblIkili_0x1.Text) },
                { Convert.ToInt32(lblIkili_1x0.Text), Convert.ToInt32(lblIkili_1x1.Text) } };

            MatrisIslemleri.IkiliMatrisYaz(dizi1, dizi2, dizi,_islem);
        }

        private void BtnOku_Ikili_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("Matris.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();
            rtbIkili.Text = "";
            while (yazi != null)       //Satır satır okuma işlemini gerçekleştirdik ve richTextBox a yazdırdık
            {
                rtbIkili.AppendText(yazi + "\n"); yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
        }

        private void BtnYaz_Tekli_Click(object sender, EventArgs e)
        {

            int[,] dizi = { { Convert.ToInt32(numericUpDownTek_0x0.Value),
                    Convert.ToInt32(numericUpDownTek_0x1.Value) },
                    { Convert.ToInt32(numericUpDownTek_1x0.Value),
                    Convert.ToInt32(numericUpDownTek_1x1.Value) } };

            if (_islem== "İz Bulma")        //Seçilen işlem yapıldı
            {
                int iz = Convert.ToInt32(lbl_iz.Text);

                MatrisIslemleri.TekliMatrisYazIz(dizi, _islem, iz);
            }
            else if(_islem == "Ters Alma" || _islem == "Transpoze")
            {
                double[,] dizi2 = { {Convert.ToDouble(lblTekli_0x0.Text), Convert.ToDouble(lblTekli_0x1.Text) },
                { Convert.ToDouble(lblTekli_1x0.Text), Convert.ToDouble(lblTekli_1x1.Text) } };

                MatrisIslemleri.TekliMatrisYaz(dizi, dizi2, _islem);
            }
        }

        private void BtnOku_Tekli_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Matris.txt", FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();
            rtbTekli.Text = "";
            while (yazi != null)       //Satır satır okuma işlemini gerçekleştirdik ve richTextBox a yazdırdık
            {
                rtbTekli.AppendText(yazi + "\n"); yazi = sw.ReadLine();
            }

            sw.Close();
            fs.Close();


        }

    }
}

