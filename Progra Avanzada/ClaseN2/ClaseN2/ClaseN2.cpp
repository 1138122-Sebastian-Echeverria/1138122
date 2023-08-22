// ClaseN2.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;

int main()
{
	int x = 10;
	int * px = & x; //Guarda la referencia en meroria 
	
	cout << px << endl; //Imprime la dirección de memoria
	cout << *px << endl; // Imprime el lo que hay en esa dirección de memoria

	*px = 37; //Para modificar el valor de lo que está en esa dirección de memoria

	cout << *px << endl; //Imprime lo que hay en esa dirección de memoria
	cout << x << endl; //Imprime el valor de x (el mismo de *px)

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////

	float notas[7];
	notas[0] = 10.2;
	notas[1] = 11.5;

		cout << notas << endl; // Imprime la dirección en donde se encuentra el primer dato del arreglo
	cout << *notas << endl; //Imprime el primer valor de lo que está en ese espacio de memoria 10.2

	cout << (notas + 1) << endl; // Imprime la dirección en donde se encuentra el siguiente dato del arreglo
	cout << *(notas + 1) << endl; // Imprime el siguiente valor de lo que está en ese espacio de memoria 11.5


}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
