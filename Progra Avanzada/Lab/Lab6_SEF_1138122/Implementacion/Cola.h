#pragma once
#include "Lista.h"

class Cola {
public:
    void Queue(char n);
    char Dequeue();
    char Top();
    int Size();
    void Invert();
    Cola(){
        datos = new Lista();
    }
private:
    Lista * datos;
};

