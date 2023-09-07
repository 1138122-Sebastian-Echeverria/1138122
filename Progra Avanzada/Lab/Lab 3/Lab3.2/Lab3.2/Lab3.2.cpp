#include <iostream>
using namespace std;
#include <string>

int main() {
    string meses[12] = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    string dSemana[7] = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom" };
    int Inicia;
    int Ano;      // Año para el que se generará el calendario
    int opcion;    // Opción para indicar si el año es bisiesto o no
    int DiasV = 0;

    // Solicitar las condiciones al usuario
    cout << "Ingrese el dia de la semana en que inicia el ano (1=Lunes, 2=Martes, ..., 7=Domingo): ";
    cin >> Inicia;

    cout << "El ano es bisiesto? (0=No, 1=Si): ";
    cin >> opcion;

    cout << "Ingrese el ano: ";
    cin >> Ano;

    cout << endl;

    // Validar el día de inicio (debe estar en el rango 1-7)
    if (Inicia < 1 || Inicia > 7) {
        cerr << "Error: El día de la semana de inicio debe estar en el rango 1-7." << endl;
        return 1;
    }

    // Ajustar el día de inicio para que sea 0 si es lunes (en lugar de 1)
    if (Inicia == 1) {
        Inicia = 0;
    }

    // Matriz con el número de días en cada mes (febrero se actualiza si es bisiesto)
    int diasEnMes[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    if (opcion == 1) {
        diasEnMes[1] = 29; // Febrero tiene 29 días en años bisiestos
    }

    cout << "Calendario: " << Ano << endl;

    // Generar e imprimir el calendario anual
    for (int mes = 1; mes < 12; mes++) {
        
        cout << meses[mes-1] << endl;

        for (int i = 0; i < 7; i++) {
            cout << dSemana[i] << "\t";
        }
        cout << endl;
        

        int dia = 1;

        if (mes > 1)
        {
            if (Inicia >= DiasV)
            {
                Inicia = (Inicia + DiasV + 1);

                if (Inicia > 7)
                {
                    Inicia = Inicia - 7;
                }
            }
            else
            {
                Inicia = (Inicia + (DiasV - Inicia) + 1);
                if (Inicia > 7)
                {
                    Inicia = Inicia - 7;
                }
            }
            
        }
           
       

        for (int semana = 0; semana < 5; semana++)
        {
            
            
            for (int diaS = 1; diaS <= 7; diaS++) {
                if (semana == 0 && diaS < Inicia) {
                    cout << " \t";
                }
                else if (dia <= diasEnMes[mes - 1]) {
                    cout << dia << "\t";
                    dia++;
                }
                else {
                    cout << " \t";
                    DiasV++;

                }
            }
            cout << endl;
            cout << endl; 
        }
    }
    return 0;
}