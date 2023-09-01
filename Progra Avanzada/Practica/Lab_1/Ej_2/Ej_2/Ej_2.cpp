// Ej_2.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;

int ProductoPunto(float *array1, float *array2, int componentes) 
{
	double decimal = (double)componentes;
	double* datos = new double[decimal];
	int comp = 0;
	double producto = 0;

	for (size_t i = 0; i < (componentes/2); i++)
	{
		datos[i] = *(array1 + i);
		comp = comp + 1;
	}

	for (size_t j = comp; j < componentes; j++)
	{
		datos[j] = *(array2 + (j - comp));
	}

	for (size_t t = 0; t < componentes/2; t++)
	{
		producto = producto + datos[t] * datos[t + (componentes / 2)];
	}

	cout << "El producto punto de ambos vectores es: " << producto;
	return producto;

}

int main()
{
	float arreglo1[3];
	float arreglo2[3];
	
	arreglo1[0] = 3;
	arreglo1[1] = 1;
	arreglo1[2] = 2;

	arreglo2[0] = 8;
	arreglo2[1] = 7;
	arreglo2[2] = 5;

	ProductoPunto(arreglo1, arreglo2, 6);

	return 0;
}

