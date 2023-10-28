#include "Lista.h"
#include <iostream>

void Lista::Add(char n) {
    // 1. Crear nodo
    Nodo * new_nodo = new Nodo();
    new_nodo->Valor = n;
    // 2. Validar si la lista esta vacia
    if (this->Size == 0){
        this->Head = new_nodo;
        this->Tail = new_nodo;
    } else {
        this->Tail->Next = new_nodo;
        this->Tail = new_nodo;
    }
    // incrementar size
    this->Size += 1;
}

void Lista::Print() {
    Nodo * actual = Head;
    while(actual != NULL){
        std::cout << actual->Valor << std::endl;
        actual = actual->Next;
    }
}


char Lista::Element_At(int index) {
    if (index >= this->Size || index < 0) return -1;

    Nodo * actual = Head;
    while(index > 0){
        actual = actual->Next;
        index--;
    }

    return actual->Valor;
}

void Lista::Remove(char n) {
    Nodo * actual = Head;
    Nodo * anterior = nullptr;
    while (actual != nullptr){
        if (actual->Valor == n){
            // procedemos a eliminar
            if (actual == Head){
                Head = actual->Next;
            }
            else if (actual == Tail){
                Tail = anterior;
            }
            else {
                anterior->Next = actual->Next;
            }

            // Reducimos Size
            this->Size--;

            // Borrar de memoria los objetos
            Nodo * borrar = actual;
            actual = actual->Next; // solo cambia actual, ya que anterior sigue siendo igual
            delete borrar;

        } else {
            //continuar
            anterior = actual;
            actual = actual->Next;
        }

    }
}

int Lista::Search(char n) {
    Nodo * actual = Head;
    int i = 0;
    while (actual != nullptr){
        if (actual->Valor == n) return i;
        i++;
        actual = actual->Next;
    }
    return -1; // valor no encontrado
}

//Insertion Sort for Lista

void InsertionSort() 
{
    Nodo* current = Head;
    Nodo* sorted = nullptr;

    while (current != nullptr) {
        Nodo* nextNode = current->Next;

        // Insertar el nodo actual en la lista ordenada
        if (sorted == nullptr || sorted->Valor >= current->Valor) {
            current->Next = sorted;
            sorted = current;
        }
        else {
            Nodo* temp = sorted;
            while (temp->Next != nullptr && temp->Next->Valor < current->Valor) {
                temp = temp->Next;
            }
            current->Next = temp->Next;
            temp->Next = current;
        }

        current = nextNode;
    }

    // Actualizar Head para apuntar a la lista ordenada
    Head = sorted;
}