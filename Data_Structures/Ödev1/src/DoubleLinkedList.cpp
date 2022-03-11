/** 
* @file DoubleLinkedList.cpp
* @description Dizi gibi davranan bir "iki yönlü bağlı liste" oluşturup dosyadan okunan bilgileri ekleme ve silme işlemleri yapar.
* @course 1-B
* @assignment 1. ödev
* @date 03.11.2021
* @author Emirhan Usta emirhan1usta@gmail.com
**/
#include "DoubleLinkedList.hpp"
#include "Node.hpp"

Node* DoubleLinkedList::FindPrevByPosition(int index) {
	//if (index < 0 || index > size) 
	Node* prv = head;
	int i = 1;
	for (Node* itr = head; itr->next != NULL && i != index; itr = itr->next, i++) {
		prv = prv->next;
	}
	return prv;
}

DoubleLinkedList::DoubleLinkedList() {
	size = 0;
}
int DoubleLinkedList::count() {
	return size;
}
bool DoubleLinkedList::isEmpty() {
	return size == 0;
}

void DoubleLinkedList::add(int index, string data) {
	if (index<0 || index>size)
	{
		index = size;
	}

	if (size==0)
	{
		head = new Node(data,NULL,NULL);
	}
	else
	{
		if (index==0)
		{
			Node* prv = FindPrevByPosition(size);
			prv->next = new Node("", NULL, prv);
			for (Node* itr = prv; itr != NULL ; itr = itr->prev)
			{
				itr->next->data = itr->data;
			}
			head->data = data;
		}
		else
		{
			Node* prv = FindPrevByPosition(size);
			prv->next = new Node("", NULL, prv);
			int i = size;
			for (Node* itr = prv; itr->prev != NULL && i != index; itr = itr->prev, i--)
			{
				itr->next->data = itr->data;
			}
			prv = FindPrevByPosition(index);
			prv->next->data = data;
		}
	}
	size++;
}

void DoubleLinkedList::remove(int index) {
	if (index < 0 || index >= size)
	{
		index = size - 1;
	}


	Node* del;
	if (index == size - 1)
	{
		Node* prv = FindPrevByPosition(index);
		del = prv->next;
		prv->next = NULL;
	}
	else
	{
		if (index == 0)
		{
			for (Node* itr = head; itr->next != NULL; itr = itr->next)
			{
				itr->data = itr->next->data;
			}
			del = FindPrevByPosition(size);
			del->prev->next = NULL;

		}
		else
		{
			Node* prv = FindPrevByPosition(index);
			del = prv->next;
			for (Node* itr = del; itr->next != NULL; itr = itr->next)
			{
				itr->data = itr->next->data;
			}
			del = FindPrevByPosition(size);
			del->prev->next = NULL;

		}
	}
	size--;
	delete del;
}
ostream& operator<<(ostream& screen, DoubleLinkedList& right)
{
	int index = 0;
	for (Node* itr = right.head; index < right.size; itr = itr->next, index++)
	{
		screen << itr->data;
		if(itr->next!=NULL){
			cout<<"<-->";
		}
		
	}
	screen << endl;
	return screen;
}
void DoubleLinkedList::clear()
{
	while (!isEmpty())
	{
		remove(0);
	}
}

DoubleLinkedList ::~DoubleLinkedList()
{
	clear();
}


