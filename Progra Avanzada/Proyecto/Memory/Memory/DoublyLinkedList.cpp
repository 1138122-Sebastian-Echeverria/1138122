#include "DoublyLinkedList.h"
#include <iostream>
#include <fstream>
#include <string>
#include <functional>
#include <sstream>

// Constructor
DoublyLinkedList::DoublyLinkedList() : head(nullptr), tail(nullptr) {}

// Método para insertar de manera ordenada
void DoublyLinkedList::insertSorted(std::string key, std::string data) {
    Node* newNode = new Node(key, data);

    // Caso 1: Lista vacía
    if (!head) {
        head = newNode;
        tail = newNode;
        return;
    }

    // Caso 2: Inserción antes del primer nodo
    if (newNode->key < head->key) {
        newNode->next = head;
        head->prev = newNode;
        head = newNode;
        return;
    }

    // Caso 3: Recorrer la lista para encontrar la posición de inserción
    Node* current = head;
    while (current->next != nullptr && current->next->key < newNode->key) {
        current = current->next;
    }

    // Caso 4: Inserción al final de la lista
    if (current->next == nullptr) {
        current->next = newNode;
        newNode->prev = current;
        tail = newNode;
    }
    // Caso 5: Inserción entre dos nodos
    else {
        newNode->next = current->next;
        newNode->prev = current;
        current->next->prev = newNode;
        current->next = newNode;
    }
}

// Método para buscar de manera binaria
Node* DoublyLinkedList::binarySearch(std::string key) {
    Node* left = head, * right = nullptr;

    while (left != right) {
        Node* mid = left;
        Node* temp = left;

        // Calcula la mitad del segmento
        int midCount = 0;
        while (temp != right && temp->next != right) {
            midCount++;
            temp = temp->next;
        }
        for (int i = 0; i < midCount / 2; i++) {
            mid = mid->next;
        }

        // Compara la llave del nodo medio
        if (mid->key == key) {
            return mid; // Llave encontrada
        }
        else if (mid->key < key) {
            left = mid->next;
        }
        else {
            right = mid;
        }
    }

    // Comprueba si la llave coincide con la del nodo de inicio (último nodo revisado)
    if (left != nullptr && left->key == key) {
        return left;
    }

    return nullptr; // Llave no encontrada
}

Node* DoublyLinkedList::getHead() const {
    return head; // Devuelve un puntero al primer nodo de la lista
}

void DoublyLinkedList::printList() const {
    Node* current = head;
    while (current != nullptr) {
        std::cout << "Llave: " << current->key << ", Datos: " << current->data << std::endl;
        current = current->next;
    }
}

