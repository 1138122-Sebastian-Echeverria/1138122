#include <iostream>
#include <string>

// Función para determinar si un año es bisiesto
bool esBisiesto(int year) {
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}

// Función para imprimir un mes dado el número de días en el mes y el día de inicio
void imprimirMes(int mes, int diasEnMes, int diaInicio) {
    // Nombres de los días de la semana
    std::string diasSemana[7] = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };

    // Nombres de los meses
    std::string meses[12] = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

    // Imprimir el nombre del mes
    std::cout << meses[mes - 1] << std::endl;

    // Imprimir los nombres de los días de la semana
    for (int i = 0; i < 7; i++) {
        std::cout << diasSemana[i] << "\t";
    }
    std::cout << std::endl;

    // Llenar el calendario con los números de los días
    int dia = 1;
    for (int semana = 0; semana < 5; semana++) {
        for (int diaSemana = 1; diaSemana <= 7; diaSemana++) {
            if (semana == 0 && diaSemana < diaInicio) {
                std::cout << " \t";
            }
            else if (dia <= diasEnMes) {
                std::cout << dia << "\t";
                dia++;
            }
            else {
                std::cout << " \t";
            }
        }
        std::cout << std::endl;
    }
}

int main() {
    int diaInicio; // Día de la semana en que inicia el año (1=Lunes, 2=Martes, ..., 7=Domingo)
    int year;      // Año para el que se generará el calendario
    int opcion;    // Opción para indicar si el año es bisiesto o no

    // Solicitar las condiciones al usuario
    std::cout << "Ingrese el día de la semana en que inicia el año (1=Lunes, 2=Martes, ..., 7=Domingo): ";
    std::cin >> diaInicio;

    std::cout << "¿El año es bisiesto? (0=No, 1=Sí): ";
    std::cin >> opcion;

    std::cout << "Ingrese el año: ";
    std::cin >> year;

    // Validar el día de inicio (debe estar en el rango 1-7)
    if (diaInicio < 1 || diaInicio > 7) {
        std::cerr << "Error: El día de la semana de inicio debe estar en el rango 1-7." << std::endl;
        return 1;
    }

    // Ajustar el día de inicio para que sea 0 si es lunes (en lugar de 1)
    if (diaInicio == 1) {
        diaInicio = 0;
    }
    else {
        diaInicio--;
    }

    // Matriz con el número de días en cada mes (febrero se actualiza si es bisiesto)
    int diasEnMes[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    if (opcion == 1 && esBisiesto(year)) {
        diasEnMes[1] = 29; // Febrero tiene 29 días en años bisiestos
    }

    // Generar e imprimir el calendario anual
    for (int mes = 1; mes <= 12; mes++) {
        imprimirMes(mes, diasEnMes[mes - 1], diaInicio);
        diaInicio = (diaInicio + diasEnMes[mes - 1]) % 7;
    }

    return 0;
}