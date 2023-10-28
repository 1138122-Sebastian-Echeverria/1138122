//
// Created by Abraham on 14/10/2023.
//

#include "Pila.h"

int Pila::Size() {
    return this->datos->Size;
}

void Pila::Push(char n) {
    this->datos->Add(n);
}

char Pila::Pop() {
    char peek = datos->Element_At(datos->Size-1);
    datos->Delete_At(datos->Size -1);
    return peek;
}

char Pila::Peek() {
    return datos->Element_At(datos->Size-1);
}

// Sebastian Echeverria Flores 1138122
// Este metodo inverte el orden de todos los datos en la pila
void Pila::Invert() 
{
    std::queue<char> tempQueue;

    // Pasa los elementos de la pila a una cola
    while (this->Size() > 0) {
        tempQueue.push(this->Pop());
    }

    // Vuelve a empujar los elementos desde la cola a la pila
    while (!tempQueue.empty()) {
        this->Push(tempQueue.front());
        tempQueue.pop();
    }
}
