/** 
* @file Test.cpp
* @description Öncelikli bir kuyrukta tutulan verileri AVL ağacına ekleyip ağacı postOrder olarak dolaşıp öncelikli olarak ekrana yazmak.
* @course 1-B
* @assignment 2. ödev
* @date 26.12.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include<iostream>
#include <clocale>
#include<fstream>
#include<string>
#include<sstream>
#include <cmath>
#include<queue>
#include<iomanip>

#include"DogruKuyrugu.hpp"
#include"AVLAgaci.hpp"

using namespace std;


void dosyaOku(AVLAgaci* avl) {
	ifstream dosyaOku("Noktalar.txt");
	string satir = "";
	string deneme = "";
	int sayac = 0;
	int x, y, z;
	if (dosyaOku.is_open()) {

		while (getline(dosyaOku, satir)) {
			DogruKuyrugu* dogruKuyrugu = new DogruKuyrugu;
			for (int i = 0; i < satir.size(); i++)
			{
				if (satir[i] != ' ')
				{
					deneme += satir[i];
				}
				else
				{
					if (sayac == 0)
					{
						x = stoi(deneme);
						deneme = "";
						sayac++;
					}
					else if (sayac == 1)
					{
						y = stoi(deneme);
						deneme = "";
						sayac++;
					}
					else
					{
						z = stoi(deneme);
						deneme = "";
						sayac = 0;
						dogruKuyrugu->ekle(x, y, z);
					}
				}
			}
			avl->ekle(dogruKuyrugu);
		}
		dosyaOku.close();
	}
}

int main() {

	AVLAgaci* agac = new AVLAgaci();

	dosyaOku(agac);

	agac->postOrder();

	delete agac;
	return 0;
}
