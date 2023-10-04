#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <sstream>
#include <algorithm>
#include <filesystem>
#include <string>
using namespace std;

class Cancion
{
public:
    string nombre;
    string artista;
    string duracion;

    Cancion(string n, string a, string d) : nombre(n), artista(a), duracion(d) {}
};
