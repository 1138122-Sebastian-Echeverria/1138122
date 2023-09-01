#include <iostream>
using namespace std;

//Primer funcion
void inicializarArreglo(int* arreglo, int length) {
	for (size_t i = 0; i < length; i++)
	{
		*(arreglo + i) = i * 2;
	}
}

//segunda funcion
void imprimirArreglo (int * arreglo, int length) {
	for (size_t i = 0; i < length; i++)
	{
		cout << *(arreglo + i) << endl;
	}
}

int modificarIndiceArreglo(int* arreglo, int length, int* dato, int posicion) {
	if (posicion >= length) 
	{
		return 0;
	}
	else
	{
		int valorOriginal = *(arreglo + posicion); //Guardar el valor original
		*(arreglo + posicion) = *dato; //Cambio de valor
		return valorOriginal;
		// arreglo[indice] = * dato
	}
}

int main()
{
	int arreglo1[20];
	int* arreglo2 = new int[20];

	inicializarArreglo(arreglo1, 20);
	imprimirArreglo(arreglo1, 20);

	int dato = 3948834;

	modificarIndiceArreglo(arreglo1, 20, &dato, 1);
	cout << arreglo1[1] << endl;


    return 0;
}
