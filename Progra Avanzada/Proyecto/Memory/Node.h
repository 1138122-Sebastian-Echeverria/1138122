#ifndef NODE_H
#define NODE_H

#include <string>

struct Node {
    std::string key;
    std::string data;
    Node* prev;
    Node* next;

    Node(std::string k, std::string d) : key(k), data(d), prev(nullptr), next(nullptr) {}
};


#endif // NODE_H
