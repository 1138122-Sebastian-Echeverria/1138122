#ifndef REGISTRO_H
#define REGISTRO_H

#include <string>
#include <vector>

class Registro {
private:
    std::string valor; // Supondremos que Registro almacena un valor simple para este ejemplo
    // Si hay más miembros, deben ser incluidos aquí

public:
    // Constructor que inicializa el valor
    Registro(const std::string& val) : valor(val) {}

    // Métodos adicionales, como getters o setters
    std::string getValor() const {
        return valor;
    }

    void setValor(const std::string& val) {
        valor = val;
    }

    // Otros métodos que necesites
};

#endif // REGISTRO_H
