#include <iostream>
using namespace std;
#include <string>

int main() {
    string meses[12] = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    string dSemana[7] = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom" };
    int Inicia;
    int Ano;      // Año para el que se generará el calendario
    int opcion;    // Opción para indicar si el año es bisiesto o no

    // Solicitar las condiciones al usuario
    cout << "Ingrese el día de la semana en que inicia el ano (1=Lunes, 2=Martes, ..., 7=Domingo): ";
    cin >> Inicia;

    cout << "¿El ano es bisiesto? (0=No, 1=Si): ";
    cin >> opcion;

    cout << "Ingrese el ano: ";
    cin >> Ano;

    // Validar el día de inicio (debe estar en el rango 1-7)
    if (Inicia < 1 || Inicia > 7) {
        cerr << "Error: El día de la semana de inicio debe estar en el rango 1-7." << endl;
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
    int diasEnMes[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    if (opcion == 1) {
        diasEnMes[1] = 29; // Febrero tiene 29 días en años bisiestos
    }

    // Generar e imprimir el calendario anual
    for (int mes = 1; mes <= 12; mes++) {
        
        cout << meses[mes - 1] << endl;

        for (int i = 0; i < 7; i++) {
            cout << dSemana[i] << "\t";
        }
        cout << endl;
        Inicia = (Inicia + diasEnMes[mes - 1]) % 7;

        int dia = 1;

        for (size_t m = 0;  m < 12;  m++)
        {
            for (size_t semana = 0; semana < 5; semana++) 
            {
                for (size_t diaSemana = 1; diaSemana <= 7; diaSemana++) 
                {
                    if (semana == 0 && diaSemana < Inicia) {
                        cout << " \t";
                    }
                    else if (dia <= diasEnMes[m]) {
                        cout << dia << "\t";
                        dia++;
                    }
                    else {
                        cout << " \t";
                    }
                }
                cout << endl;
            }

        }
    }

    return 0;
}