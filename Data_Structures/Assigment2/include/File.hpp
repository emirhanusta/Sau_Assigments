#ifndef FILE_HPP
#define FILE_HPP

#include<iostream>
#include <clocale>
#include<fstream>
#include<string>
#include<sstream>
#include "Node.hpp"
#include "DoubleLinkedList.hpp"

class File
{
private:
	string firstParameter, secondParameter, thirdParameter;
public:
	File();
	void readFile(DoubleLinkedList*);
};

#endif