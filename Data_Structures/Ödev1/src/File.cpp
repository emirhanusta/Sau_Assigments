/** 
* @file File.cpp
* @description Dizi gibi davranan bir "iki yönlü bağlı liste" oluşturup dosyadan okunan bilgileri ekleme ve silme işlemleri yapar.
* @course 1-B
* @assignment 1. ödev
* @date 03.11.2021
* @author Emirhan Usta  emirhan1usta@gmail.com
**/

#include "File.hpp"
#include "DoubleLinkedList.hpp"

File::File() {
}

void File::readFile(DoubleLinkedList* list) {

	ifstream readFile("Veri.txt");
	string line;
	while (getline(readFile, line)) {
		if (line[0] == 'E')
		{
			stringstream ss(line);
			getline(ss, firstParameter, '(');
			getline(ss, secondParameter, '#');
			getline(ss, thirdParameter, ')');

			int index = stoi(secondParameter);
			list->add(index, thirdParameter);
		}
		else
		{
			stringstream ss(line);
			getline(ss, firstParameter, '(');
			getline(ss, secondParameter, ')');

			int index = stoi(secondParameter);
			list->remove(index);
		}
	}
	readFile.close();
}