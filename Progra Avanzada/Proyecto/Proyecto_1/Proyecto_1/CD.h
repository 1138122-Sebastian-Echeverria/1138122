#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <sstream>
#include <algorithm>
#include <filesystem>
#include <string>
#include "Cancion.h"
using namespace std;

class CD
{
public:
    string nombreCD;
    vector<Cancion> canciones;

    CD(string n) : nombreCD(n) {}

    void agregarCancion(const Cancion& cancion) {
        canciones.push_back(cancion);
    }
};

