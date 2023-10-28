//
// Created by Joseph Abraham Soto on 5/10/23.
//

#include "Cola.h"

int Cola::Size() {
    return this->datos->Size;
}

void Cola::Queue(char n) {
    this->datos->Add(n);
}

char Cola::Dequeue() {
    // Recupero el dato de la primera posicion
    if (datos->Size > 0){
        char valor = this->datos->Element_At(0);
        Nodo * actual = datos->Head;
        this->datos->Head = actual->Next;
        delete actual; // eliminar de memoria
        this->datos->Size--;
        return valor;
    } else {
        return -1;
    }
}

char Cola::Top() {
    return datos->Element_At(0);
}

//Sebastian Echeverria Flores 1138122
// Este metodo inverte el orden de todos los datos la cola
void Cola::Invert() {
    std::stack<char> tempStack;

    // Pasa los elementos de la cola a una pila
    while (this->datos->Size > 0) {
        tempStack.push(this->Dequeue());
    }

    // Vuelve a encolar los elementos desde la pila a la cola
    while (!tempStack.empty()) {
        this->Queue(tempStack.top());
        tempStack.pop();
    }
}

