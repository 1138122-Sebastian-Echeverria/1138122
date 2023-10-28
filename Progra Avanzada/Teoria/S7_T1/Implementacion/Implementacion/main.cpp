#include <iostream>
#include "Lista.h"
#include "Cola.h"
int main() {
    Lista * listaEnClase = new Lista();
    listaEnClase->Add('a');
    listaEnClase->Add('b');
    listaEnClase->Add('r');
    listaEnClase->Add('a');
    listaEnClase->Add('h');
    listaEnClase->Add('a');
    listaEnClase->Add('m');

    listaEnClase->Print();

    std::cout << listaEnClase->Element_At(-1) << std::endl;
    std::cout << listaEnClase->Element_At(0) << std::endl;
    std::cout << listaEnClase->Element_At(1) << std::endl;
    std::cout << listaEnClase->Element_At(2) << std::endl;
    std::cout << listaEnClase->Element_At(3) << std::endl;
    std::cout << listaEnClase->Element_At(4) << std::endl;
    std::cout << listaEnClase->Element_At(5) << std::endl;
    std::cout << listaEnClase->Element_At(6) << std::endl;
    std::cout << listaEnClase->Element_At(7) << std::endl;

    listaEnClase->Remove('a');
    std::cout << "Remove donde" << std::endl;
    listaEnClase->Print();
    std::cout << listaEnClase->Size << std::endl;
    std::cout << listaEnClase->Search('b') << std::endl;
    std::cout << listaEnClase->Element_At(listaEnClase->Search('b')) << std::endl;

    Cola * colaEnClase = new Cola();
    colaEnClase->Queue('a');
    colaEnClase->Queue('b');
    colaEnClase->Queue('r');
    colaEnClase->Queue('a');
    colaEnClase->Queue('h');
    colaEnClase->Queue('a');
    colaEnClase->Queue('m');
    std::cout << "Cola" << std::endl;

    std::cout << colaEnClase->Size() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Dequeue() << std::endl;
    std::cout << colaEnClase->Size() << std::endl;
}
