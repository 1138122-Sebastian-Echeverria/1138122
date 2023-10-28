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
    void Delete_At(int position);
    int Search(char n); // Return -1 si el elemento no existe, o el indice caso contrario
    void Print();
    char Element_At(int index);

    void AddSorted(char n);
    void PrintRecursive(); // cambie la definicion segun considere apropiado, pero no el nombre
    void PrintInverse(); // cambie la definicion segun considere apropiado, pero no el nombre
    void PrintInverseUtil();
    Lista(){
        Head = nullptr;
        Tail = nullptr;
        Size = 0;
    }
};



