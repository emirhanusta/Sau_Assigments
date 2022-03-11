#ifndef DOGRUKUYRUGU_HPP
#define DOGRUKUYRUGU_HPP

#include"Dugum.hpp"

class DogruKuyrugu
{
public:
	DogruKuyrugu();
	~DogruKuyrugu();
	void ekle(int x, int y, int z);
	int toplamUzunlukBul();
	void orijineUzaklikYaz();
	void enKucuguCikar();

	Dugum* enKucugunOncekiDugum();

	int enKucukGetir();

private:
	Dugum* ilk;
	Dugum* son;
};

#endif