#pragma once
#include "Texto.h"
#include <iostream>
#include <string>
using namespace std;

class Parrafo : public Texto
{
private:
    int numTextos;
    Texto(cadena);


public:
    Parrafo(std::string* textos, int numTextos) : Texto(""), numTextos(numTextos) {
        string p�rrafoCompleto = "";
        for (int i = 0; i < numTextos; i++) {
            p�rrafoCompleto += textos[i];
            if (i < numTextos - 1) {
                p�rrafoCompleto += '\n';
            }
        }
        cadena = p�rrafoCompleto;
    }

    long getLength() const {
        return cadena.length();
    }

    char** toCharMatriz() {
        char** charMatrix = new char* [numTextos];
        for (int i = 0; i < numTextos; i++) {
            charMatrix[i] = new char[cadena.length() + 1];
            strcpy(charMatrix[i], cadena.c_str());
        }
        return charMatrix;
    }

    Parrafo() {
        char** charMatrix = toCharMatriz();
        for (int i = 0; i < numTextos; i++) {
            delete[] charMatrix[i];
        }
        delete[] charMatrix;
    }
};

