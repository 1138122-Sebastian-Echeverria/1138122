#pragma once
#include "Lista.h"
class Pila {
public:
    void Push(char a);
    char Pop();
    char Peek();
    int Size();
    void Invert();
    Pila(){
        datos = new Lista();
    }

private:
    Lista * datos;
};
