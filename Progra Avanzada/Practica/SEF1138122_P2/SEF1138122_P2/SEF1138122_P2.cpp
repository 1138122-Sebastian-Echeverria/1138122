// SEF1138122_P2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


int main()
{


   ;int opcion = 0;

   do {
       cout << "\n--- Menu ---" << endl;
       cout << "1. Cargar respaldos" << endl;
       cout << "2. Agregar Cancion" << endl;
       cout << "3. Ver Cola de Reproduccion" << endl;
       cout << "Seleccione una opcion:" << endl;
       while (!(cin >> opcion)) {
           cout << "Por favor, ingrese un número válido: ";
           cin.clear();
           cin.ignore(numeric_limits<streamsize>::max(), '\n');
       }

       switch (opcion) {
       case 1:
           
           break;
       case 2:
           
           break;
       case 3:

           break;
       case 4:
           break;
       default:
           cout << "Opción no válida. Por favor, intente nuevamente." << endl;
           break;
       }

       // Pausar y esperar que el usuario presione enter para continuar
       cout << "\nPresione ENTER para continuar...";
       cin.ignore(numeric_limits<streamsize>::max(), '\n');
       cin.get();

   } while (opcion != 4);

   return 0;
}
}
