#include "hashFunction.h"
#include <iostream>
#include <fstream>
#include <string>
#include <functional>
#include <sstream>

std::string hashFunction(const std::string& key) {
    std::hash<std::string> hasher;
    size_t hashedValue = hasher(key);
    std::string hash = std::to_string(hashedValue);

    // Recortar o rellenar el hash para que tenga exactamente 10 caracteres
    if (hash.length() > 10) {
        hash = hash.substr(0, 10);
    }
    else {
        while (hash.length() < 10) {
            hash += '0';
        }
    }
    return hash;
}
