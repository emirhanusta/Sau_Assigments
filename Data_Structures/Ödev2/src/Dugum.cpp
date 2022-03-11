/** 
* @file Dugum.cpp
* @description Öncelikli bir kuyrukta tutulan verileri AVL ağacına ekleyip ağacı postOrder olarak dolaşıp öncelikli olarak ekrana yazmak.
* @course 1-B
* @assignment 2. ödev
* @date 26.12.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include"Dugum.hpp"

	Dugum::Dugum(int x,int y,int z)
	{
		this->x = x;
		this->y = y;
		this->z = z;
		sonraki = 0;
        orijineUzaklik = (int)sqrt(pow(x, 2) + pow(y, 2) + pow(z, 2));
	}
