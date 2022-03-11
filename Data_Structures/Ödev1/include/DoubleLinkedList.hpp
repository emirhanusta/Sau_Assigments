#ifndef DOUBLELINKEDLIST_HPP
#define DOUBLELINKEDLIST_HPP

#include"Node.hpp"

class DoubleLinkedList
{
private:
	Node* head;
	int size;

	Node* FindPrevByPosition(int);
public:
	DoubleLinkedList();
	~DoubleLinkedList();
	int count();
	bool isEmpty();
	void add(int, string);
	void remove(int);
	void clear();
	friend ostream& operator<<(ostream&, DoubleLinkedList&);

};

#endif