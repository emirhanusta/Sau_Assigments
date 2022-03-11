/** 
* @file DugumAvl.cpp
* @description Öncelikli bir kuyrukta tutulan verileri AVL ağacına ekleyip ağacı postOrder olarak dolaşıp öncelikli olarak ekrana yazmak.
* @course 1-B
* @assignment 2. ödev
* @date 26.12.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include"DugumAvl.hpp"

DugumAvl::DugumAvl(DogruKuyrugu* kuyruk)
{
    k = kuyruk;
    this->veri = k->toplamUzunlukBul();

    sol = sag = 0;
};
