/** 
* @file Test.cpp
* @description Dizi gibi davranan bir "iki yönlü bağlı liste" oluşturup dosyadan okunan bilgileri ekleme ve silme işlemleri yapar.
* @course 1-B
* @assignment 1. ödev
* @date 03.11.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include <iostream>
#include <string>
#include <sstream>
#include<fstream>
#include"Node.hpp"
#include"DoubleLinkedList.hpp"
#include"File.hpp"

using namespace std;

int main()
{
	DoubleLinkedList* list = new DoubleLinkedList();
	File* file = new File();

	file->readFile(list);
	cout << * list ;

	delete list, file;
	return 0;
}