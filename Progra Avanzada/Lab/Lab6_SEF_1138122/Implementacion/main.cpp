#include <iostream>
#include "Lista.h"
#include "Cola.h"
#include "Pila.h"

int main() {
    Lista * ejemploLista = new Lista();
    ejemploLista->Add('a');
    ejemploLista->Add('b');
    ejemploLista->Add('r');
    ejemploLista->Add('a');
    ejemploLista->Add('h');
    ejemploLista->Add('a');
    ejemploLista->Add('m');

    ejemploLista->Print();

    std::cout << ejemploLista->Element_At(-1) << std::endl;
    std::cout << ejemploLista->Element_At(0) << std::endl;
    std::cout << ejemploLista->Element_At(1) << std::endl;
    std::cout << ejemploLista->Element_At(2) << std::endl;
    std::cout << ejemploLista->Element_At(3) << std::endl;
    std::cout << ejemploLista->Element_At(4) << std::endl;
    std::cout << ejemploLista->Element_At(5) << std::endl;
    std::cout << ejemploLista->Element_At(6) << std::endl;
    std::cout << ejemploLista->Element_At(7) << std::endl;

    ejemploLista->Remove('a');
    std::cout << "Remove done" << std::endl;
    ejemploLista->Print();
    std::cout << ejemploLista->Size << std::endl;
    std::cout << ejemploLista->Search('b') << std::endl;
    std::cout << ejemploLista->Element_At(ejemploLista->Search('b')) << std::endl;

    std::cout << "Delete_At() done" << std::endl;
    ejemploLista->Delete_At(0);
    ejemploLista->Delete_At(1);
    ejemploLista->Delete_At(1);
    ejemploLista->Delete_At(0);
    ejemploLista->Print();


    std::cout << "Cola" << std::endl;
    Cola * ejemploCola = new Cola();
    ejemploCola->Queue('a');
    ejemploCola->Queue('b');
    ejemploCola->Queue('r');
    ejemploCola->Queue('a');
    ejemploCola->Queue('h');
    ejemploCola->Queue('a');
    ejemploCola->Queue('m');

    std::cout << ejemploCola->Size() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Dequeue() << std::endl;
    std::cout << ejemploCola->Size() << std::endl;

    std::cout << "Pila" << std::endl;
    Pila * ejemploPila = new Pila();
    ejemploPila->Push('a');
    ejemploPila->Push('b');
    ejemploPila->Push('r');
    ejemploPila->Push('a');
    ejemploPila->Push('h');
    ejemploPila->Push('a');
    ejemploPila->Push('m');

    std::cout << "Peek: " << ejemploPila->Peek() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;
    std::cout << "Pop: " << ejemploPila->Pop() << std::endl;


}
