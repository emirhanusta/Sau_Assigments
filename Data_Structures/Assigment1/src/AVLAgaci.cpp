/** 
* @file AVLAgaci.cpp
* @description Öncelikli bir kuyrukta tutulan verileri AVL ağacına ekleyip ağacı postOrder olarak dolaşıp öncelikli olarak ekrana yazmak.
* @course 1-B
* @assignment 2. ödev
* @date 26.12.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include"AVLAgaci.hpp"

void AVLAgaci::Temizle() {
    while (kok != 0) dugumSil(kok);
}

AVLAgaci::AVLAgaci()
{
    kok = 0;
}

AVLAgaci::~AVLAgaci()
{
    Temizle();
}
void AVLAgaci::ekle(DogruKuyrugu* eklenecek)
{
    kok = ekle(eklenecek, kok);
};

void AVLAgaci::postOrder() {
    postOrder(kok);
    cout << endl;
}

int AVLAgaci::dengesizlikYonu(DugumAvl* aktif)
{
    if (aktif == 0)
        return 0;
    return yukseklik(aktif->sol) - yukseklik(aktif->sag);
}

DugumAvl* AVLAgaci::solaDondur(DugumAvl* buyukEbeveyn)
{
    DugumAvl* sagCocuk = buyukEbeveyn->sag;
    buyukEbeveyn->sag = sagCocuk->sol;
    sagCocuk->sol = buyukEbeveyn;
    return sagCocuk;
}

DugumAvl* AVLAgaci::sagaDondur(DugumAvl* buyukEbeveyn)
{
    DugumAvl* solCocuk = buyukEbeveyn->sol;
    buyukEbeveyn->sol = solCocuk->sag;
    solCocuk->sag = buyukEbeveyn;
    return solCocuk;
}

void AVLAgaci::postOrder(DugumAvl* aktif)
{
    if (aktif)
    {
        postOrder(aktif->sol);
        postOrder(aktif->sag);
        aktif->k->orijineUzaklikYaz();
        cout << endl;
        delete aktif->k; //oluşturulan dogrukuyrugu nesnesi silindi
    }
}
int AVLAgaci::yukseklik(DugumAvl* aktifDugum)
{
    if (aktifDugum)
    {
        return 1 + max(yukseklik(aktifDugum->sol),
            yukseklik(aktifDugum->sag));
    }
    return -1;
}

int AVLAgaci::minDeger(DugumAvl* aktif)
{
    if (aktif->sol)
        return maxDeger(aktif->sol);

    return aktif->veri;
}

int AVLAgaci::maxDeger(DugumAvl* aktif)
{
    if (aktif->sag)
        return maxDeger(aktif->sag);

    return aktif->veri;
}

DugumAvl* AVLAgaci::ekle(DogruKuyrugu* kuyruk, DugumAvl* aktifDugum)
{
    int veri = kuyruk->toplamUzunlukBul();
    if (aktifDugum == 0)
        return new DugumAvl(kuyruk);

    else if (aktifDugum->veri < veri)
    {
        aktifDugum->sag = ekle(kuyruk, aktifDugum->sag);
        if (yukseklik(aktifDugum->sag) - yukseklik(aktifDugum->sol) > 1)
        {
            if (veri > aktifDugum->sag->veri)
                aktifDugum = solaDondur(aktifDugum);

            else
            {
                aktifDugum->sag = sagaDondur(aktifDugum->sag);
                aktifDugum = solaDondur(aktifDugum);
            }
        }
    }
    else if (aktifDugum->veri > veri)
    {
        aktifDugum->sol = ekle(kuyruk, aktifDugum->sol);
        if (yukseklik(aktifDugum->sol) - yukseklik(aktifDugum->sag) > 1)
        {

            if (veri < aktifDugum->sol->veri)
                aktifDugum = sagaDondur(aktifDugum);
            else
            {
                aktifDugum->sol = solaDondur(aktifDugum->sol);
                aktifDugum = sagaDondur(aktifDugum);
            }
        }

    }
    return aktifDugum;
}

bool AVLAgaci::dugumSil(DugumAvl*& aktif) {

    DugumAvl* silinecek = aktif;

    if (aktif->sag == NULL) aktif = aktif->sol;
    else if (aktif->sol == NULL) aktif = aktif->sag;
    else {
        silinecek = aktif->sol;
        DugumAvl* ebeveyn = aktif;
        while (silinecek->sag != NULL) {
            ebeveyn = silinecek;
            silinecek = silinecek->sag;
        }
        aktif->veri = silinecek->veri;
        if (ebeveyn == aktif) aktif->sol = silinecek->sol;
        else ebeveyn->sag = silinecek->sol;
    }
    delete silinecek;
    return true;
}
