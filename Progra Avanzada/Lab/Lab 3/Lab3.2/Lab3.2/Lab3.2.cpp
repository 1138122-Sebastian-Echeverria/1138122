using namespace std;
#include <iostream>
#include <string>

int main() {
    int Inicia; // Día de la semana en que inicia el año (1=Lunes, 2=Martes, ..., 7=Domingo)
    int year;      // Año para el que se generará el calendario
    int Op;    // Opción para indicar si el año es bisiesto o no

    // Solicitar las condiciones al usuario
    cout << "Ingrese el día de la semana en que inicia el ano (1=Lunes, 2=Martes, ..., 7=Domingo): ";
    cin >> Inicia;

    cout << "¿El año es bisiesto? (0=No, 1=Si): ";
    cin >> Op;

    cout << "Ingrese el ano: ";
    cin >> year;

    // Validar el día de inicio (debe estar en el rango 1-7)
    if (Inicia < 1 || Inicia > 7) {
        cerr << "Error: El dia de la semana de inicio debe estar en el rango 1-7." << endl;
        return 1;
    }

    // Ajustar el día de inicio para que sea 0 si es lunes (en lugar de 1)
    if (Inicia == 1) {
        Inicia = 0;
    }
    else {
        Inicia--;
    }

    // Matriz con el número de días en cada mes (febrero se actualiza si es bisiesto)
    int diasmes[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    if (Op == 1) {
        diasmes[1] = 29; // Febrero tiene 29 días en años bisiestos
    }

    // Nombres de los días de la semana
    string diasS[7] = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom" };

    // Nombres de los meses
    string meses[12] = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

    // Generar e imprimir el calendario anual
    for (int mes = 0; mes < 12; mes++) {
        // Imprimir el nombre del mes
        cout << meses[mes] << endl;

        // Imprimir los nombres de los días de la semana
        for (int i = 0; i < 7; i++) {
            cout << diasS[i] << "\t";
        }
        cout << endl;

        // Llenar el calendario con los números de los días
        int dia = 1;
        for (int semana = 0; semana < 5; semana++) {
            for (int diaSemana = 0; diaSemana < 7; diaSemana++) {
                if (semana == 0 && diaSemana < Inicia) {
                    cout << " \t";
                }
                else if (dia <= diasmes[mes]) {
                    cout << dia << "\t";
                    dia++;
                }
                else {
                    cout << " \t";
                }
            }
            cout << endl;
        }

        Inicia = (Inicia + diasmes[mes]) % 7;
    }

    return 0;
}