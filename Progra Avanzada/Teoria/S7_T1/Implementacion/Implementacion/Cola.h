#pragma once
#include "Lista.h"

class Cola {
public:
    void Queue(char n);
    char Dequeue();
    char Peek();
    int Size();
    Cola(){
        datos = new Lista();
    }
private:
    Lista * datos;
};

