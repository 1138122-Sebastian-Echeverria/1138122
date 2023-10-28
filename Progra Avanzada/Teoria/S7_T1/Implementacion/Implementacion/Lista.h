//
#pragma once
#include "Nodo.h"

class Lista {
public:
    Nodo * Head;
    Nodo * Tail;
    int Size;
    void Add(char n);
    void Remove(char n);
    int Search(char n); // Return -1 si el elemento no existe, o el indice caso contrario
    void Print();
    char Element_At(int index);

    Lista(){
        Head = nullptr;
        Tail = nullptr;
        Size = 0;
    }
};



