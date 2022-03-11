#ifndef DUGUM_HPP
#define DUGUM_HPP

#include<iostream>
#include <clocale>
#include<fstream>
#include<string>
#include<sstream>
#include <cmath>
#include<queue>
#include<iomanip>


using namespace std;
class Dugum
{
public:
	Dugum(int x, int y, int z);
	int x;
	int y;
	int z;
	int orijineUzaklik;
	Dugum* sonraki;
};
#endif