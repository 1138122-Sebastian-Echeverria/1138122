#include "Tuples.h"
#include <iostream>

void Tuples::set_element_at(Tuple value, int position) {
    if (position >= length || position < 0) throw ("La posicion indicada es invalida.");
    elements[position] = value;

}


void Tuples::print_elements() {
    for (int i = 0; i <= length; ++i) {
        std::cout << elements[i].to_string() << " ";
    }
    std::cout << std::endl;
}

void Tuples::sort_elements() {
    quicksort(0, length - 1);
}

void Tuples::quicksort(int low, int high) {
    if (low < high) {
        // Usa el último elemento como pivote
        Tuple pivot = elements[high];
        int i = low; // Índice del elemento más pequeño

        for (int j = low; j <= high - 1; ++j) {
            // Si el elemento actual es menor o igual al pivote
            if ((elements[j].first + elements[j].last) <= (pivot.first + pivot.last)) {
                // Intercambia elements[i] y elements[j]
                Tuple temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
                ++i;
            }
        }
        // Intercambia elements[i] y el pivote
        Tuple temp = elements[i];
        elements[i] = elements[high];
        elements[high] = temp;

        // Llama recursivamente a quicksort para las dos sub-arrays
        quicksort(low, i - 1);
        quicksort(i + 1, high);
    }
}
