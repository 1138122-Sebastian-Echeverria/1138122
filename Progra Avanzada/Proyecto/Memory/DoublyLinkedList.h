#ifndef DOUBLYLINKEDLIST_H
#define DOUBLYLINKEDLIST_H

#include "Node.h"
#include <string>

class DoublyLinkedList {
    Node* head;
    Node* tail;

public:
    DoublyLinkedList();
    void insertSorted(std::string key, std::string data);
    Node* binarySearch(std::string key);
    Node* getHead() const;
};

#endif // DOUBLYLINKEDLIST_H
