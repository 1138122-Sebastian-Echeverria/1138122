#include <iostream>
#include <fstream>
#include <string>
#include <functional>
#include <sstream>
#include "DoublyLinkedList.h"
#include "hashFunction.h"

void loadDataFromFile(const std::string& filename, DoublyLinkedList& list) {
    std::ifstream file(filename);
    if (!file) {
        std::cerr << "No se pudo abrir el archivo: " << filename << std::endl;
        return;
    }

    std::string line;
    while (std::getline(file, line)) {
        std::istringstream iss(line);
        std::string key, data;

        // Intenta extraer la llave y los datos de la línea.
        if (std::getline(iss, key, ',') && std::getline(iss, data)) {
            std::string hashedKey = hashFunction(key);

            std::cout << "Leyendo linea: " << line << std::endl; // Mensaje de depuración
            // Inserta el par llave-datos en la lista.
            list.insertSorted(hashedKey, data);
        }
        else {  
            // Manejo de errores en caso de formato incorrecto de línea.
            std::cerr << "Formato de linea incorrecto: " << line << std::endl;
        }
    }

    file.close();
}


void searchByKey(DoublyLinkedList& list, const std::string& key) {
    std::string hashedKey = hashFunction(key);
    Node* result = list.binarySearch(hashedKey);

    if (result != nullptr) {
        std::cout << "Datos encontrados: " << result->data << std::endl;
    }
    else {
        std::cout << "No se encontraron datos con la llave: " << key << std::endl;
    }
}


void searchByValue(DoublyLinkedList& list, const std::string& value) {
    Node* current = list.getHead();
    bool found = false;

    while (current != nullptr) {
        if (current->data == value) {
            std::cout << "Datos encontrados: " << current->data << std::endl;
            found = true;
        }
        current = current->next;
    }

    if (!found) {
        std::cout << "No se encontraron datos con el valor: " << value << std::endl;
    }
}



int main() {
    DoublyLinkedList list;
    int option;
    std::string input;

    do {
        std::cout << "1. Cargar mas datos\n";
        std::cout << "2. Buscar por llave\n";
        std::cout << "3. Buscar por valor\n";
        std::cout << "4. Salir\n";
        std::cout << "Ingrese una opcion: ";
        std::cin >> option;

        switch (option) {
        case 1:
            std::cout << "Ingrese la ruta del archivo: ";
            std::cin >> input;
            loadDataFromFile(input, list);
            break;
        case 2:
            std::cout << "Ingrese la llave a buscar: ";
            std::cin >> input;
            searchByKey(list, input);
            break;
        case 3:
            std::cout << "Ingrese el valor a buscar: ";
            std::cin >> input;
            searchByValue(list, input);
            break;
        case 4:
            std::cout << "Saliendo...\n";
            break;
        default:
            std::cout << "Opcion no valida. Intente de nuevo.\n";
        }
    } while (option != 4);

    return 0;
}

    