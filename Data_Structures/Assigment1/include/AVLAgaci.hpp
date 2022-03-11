#ifndef AVLAGACI_HPP
#define AVLAGACI_HPP

#include"DogruKuyrugu.hpp"
#include"DugumAvl.hpp"

class AVLAgaci
{
public:

	void Temizle();
	AVLAgaci();

	~AVLAgaci();
	void ekle(DogruKuyrugu*);

	void postOrder();
private:
	int dengesizlikYonu(DugumAvl*);
	DugumAvl* solaDondur(DugumAvl*);
	DugumAvl* sagaDondur(DugumAvl*);

	void postOrder(DugumAvl*);

	int yukseklik(DugumAvl*);

	int minDeger(DugumAvl*);
	int maxDeger(DugumAvl*);

	DugumAvl* ekle(DogruKuyrugu*, DugumAvl*);
	bool dugumSil(DugumAvl*&);

	DugumAvl* kok;
};


#endif