/** 
* @file DogruKuyrugu.cpp
* @description Öncelikli bir kuyrukta tutulan verileri AVL ağacına ekleyip ağacı postOrder olarak dolaşıp öncelikli olarak ekrana yazmak.
* @course 1-B
* @assignment 2. ödev
* @date 26.12.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include"DogruKuyrugu.hpp"


DogruKuyrugu::DogruKuyrugu()
{
	ilk = son = 0;
}
DogruKuyrugu::~DogruKuyrugu()
{
	while (ilk != 0)
	{
		Dugum* gec = ilk;
		ilk = ilk->sonraki;
		delete gec;
	}
}
void DogruKuyrugu::ekle(int x, int y, int z)
{
	if (ilk == 0)
	{
		ilk = new Dugum(x, y, z);
		son = ilk;
	}
	else
	{
		Dugum* yeni = new Dugum(x, y, z);
		son->sonraki = yeni;
		son = yeni;
	}
}
int DogruKuyrugu::toplamUzunlukBul() {
	int toplamUzunluk = 0;

	Dugum* temp = ilk;
	while (temp->sonraki != 0)
	{
		toplamUzunluk += (int)sqrt(pow(temp->sonraki->x - temp->x, 2) + pow(temp->sonraki->y - temp->y, 2) + pow(temp->sonraki->z - temp->z, 2));
		temp = temp->sonraki;
	}
	return toplamUzunluk;
}
void DogruKuyrugu::orijineUzaklikYaz() {
	Dugum* temp = ilk;
	while (ilk != 0)
	{
		cout << enKucukGetir() << "  ";
		enKucuguCikar();
	}
}
void DogruKuyrugu::enKucuguCikar()
{
	Dugum* onceki = enKucugunOncekiDugum();
	if (onceki)
	{
		if (onceki->sonraki == son)
			son = onceki;
		Dugum* sil = onceki->sonraki;
		onceki->sonraki = sil->sonraki;
		delete sil;
	}
	else
	{
		if (ilk == 0)
			return;
		Dugum* sil = ilk;
		ilk = ilk->sonraki;
		delete sil;
	}
}

Dugum* DogruKuyrugu::enKucugunOncekiDugum()
{
	if (ilk == 0)	return 0;

	Dugum* gec = ilk;
	Dugum* onceki = 0;
	int enKucuk = gec->orijineUzaklik;

	while (gec->sonraki != 0)
	{
		if (gec->sonraki->orijineUzaklik < enKucuk)
		{
			enKucuk = gec->sonraki->orijineUzaklik;
			onceki = gec;
		}
		gec = gec->sonraki;
	}
	return onceki;
}

int DogruKuyrugu::enKucukGetir()
{
	Dugum* onceki = enKucugunOncekiDugum();

	if (onceki)
		return onceki->sonraki->orijineUzaklik;
	if (ilk != 0)
		return ilk->orijineUzaklik;
}
