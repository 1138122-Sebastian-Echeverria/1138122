// Introduccion.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include "ejemplo.h";
using namespace std;

int main()
{
    // Utilizar clase
    ejemplo* objetoDeClaseEjemplo = new ejemplo();

    cout << objetoDeClaseEjemplo->edades << endl;
    cout << objetoDeClaseEjemplo->presupuesto << endl;
    cout << objetoDeClaseEjemplo->CalcularPresupuestoEdad(10, 10) << endl;

    /*/
    // Structura basica
    int x = 10100101;

    cout << "Hello World!" << x << endl;

    // Pedir datos
    int edad; //Si se utiliza "u_int" se imprimen numeros positivos hasta el maximo posible.
    cin >> edad;
    cout << edad << endl;

    //tipoa de datos
    string nombre = "Juan Pedro";
    cout << nombre << endl;

    bool estado = false;
    cout << estado << endl;
    
    double interes = 10.123123123123f;
    cout << interes << endl;

    
    char letra = 'a';
    cout << letra << endl;
    
    int edades[10];
    cout << edades << endl;
    cout << edades+1 << endl;

    edades[0] = -1;
    cout << edades[0] << endl;
    
    edades[2] = -3;
    cout << edades[2] << endl;
    
    edades[4] = -4;
    cout << edades[4] << endl;
    
    edades[6] = -5;
    cout << edades[6] << endl;
    cout << *edades << endl;

    double calculos[10];
    cout << "Double array" << endl;
    cout << calculos << endl;
    cout << calculos + 1 << endl;
    cout << calculos - 1 << endl;

    cout << *(edades + 6) << endl;/*/

    return 0;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
