/** 
* @file Node.cpp
* @description Dizi gibi davranan bir "iki yönlü bağlı liste" oluşturup dosyadan okunan bilgileri ekleme ve silme işlemleri yapar.
* @course 1-B
* @assignment 1. ödev
* @date 03.11.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/

#include "Node.hpp"

Node::Node(const string data, Node* next = NULL, Node* prev = NULL) {
	this->data = data;
	this->next = next;
	this->prev = prev;
}
