#ifndef REGISTRO_H
#define REGISTRO_H

#include <string>

class Registro {
private:
    std::string valor;

public:
    Registro() : valor("") {}

    Registro(std::string val) : valor(val) {}

    std::string obtenerValor() const {
        return valor;
    }
};

#endif // REGISTRO_H
