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

void Lista::Delete_At(int index) {
    if (index >= this->Size || index < 0) return;

    // borrar head?
    if (index == 0){
        Nodo * aBorrar = Head;
        Head = Head->Next;
        Size--;
        delete aBorrar;
        return;
    }

    Nodo * actual = Head->Next;
    Nodo * anterior = Head;
    while(index > 1) {
        anterior = actual;
        actual = actual->Next;
        index--;
    }

    Nodo * aBorrar = actual;
    anterior->Next = actual->Next;
    Size--;
    delete aBorrar;

    if (index == Size -1) // tail?
    {
        Tail = anterior;
    }
}

// Al utilizar este metodo, los datos insertados se haran en orden ascedente.
// Verifique la tabla ASCII para conocer el orden de los datos.
void Lista::AddSorted(char n) {
    Nodo* new_nodo = new Nodo();
    new_nodo->Valor = n;
    new_nodo->Next = nullptr;

    if (Size == 0) {
        // Si la lista está vacía, simplemente agrega el nuevo nodo.
        Head = Tail = new_nodo;
    }
    else {
        Nodo* actual = Head;
        Nodo* anterior = nullptr;

        // Encuentra el lugar correcto para insertar el nuevo nodo.
        while (actual != nullptr && actual->Valor < n) {
            anterior = actual;
            actual = actual->Next;
        }

        // Inserta el nuevo nodo en la posición correcta.
        if (anterior == nullptr) {
            // Insertar al principio de la lista.
            new_nodo->Next = Head;
            Head = new_nodo;
        }
        else if (actual == nullptr) {
            // Insertar al final de la lista.
            Tail->Next = new_nodo;
            Tail = new_nodo;
        }
        else {
            // Insertar en el medio de la lista.
            anterior->Next = new_nodo;
            new_nodo->Next = actual;
        }
    }

    // Incrementa el tamaño de la lista.
    Size++;
}

//Sebastian Echeverria Flores 1138122
// Este metodo imprime la lista de datos de forma recursiva
// en el orden en que se ingresaron (desde el HEAD hasta TAIL)
void Lista::PrintRecursive() {
    PrintRecursiveUtil(Head);
}

void Lista::PrintRecursiveUtil(Nodo* current) {
    if (current == nullptr) {
        return;
    }

    // Imprime el valor del nodo actual y luego llama recursivamente con el siguiente nodo.
    std::cout << current->Valor << " ";
    PrintRecursiveUtil(current->Next);
}


// Este metodo imprie la lista de datos
// en el orden inverso al que se ingresaron (desde TAIL hasta HEAD)
void Lista::PrintInverse() {
    PrintInverseUtil(Head);
}

void Lista::PrintInverseUtil() {
    if (current == nullptr) {
        return;
    }

    // Llama recursivamente con el siguiente nodo y luego imprime el valor del nodo actual.
    PrintInverseUtil(current->Next);
    std::cout << current->Valor << " ";
}