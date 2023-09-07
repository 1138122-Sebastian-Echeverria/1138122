// Lab_3.1.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
using namespace std;


float** transponer(float** matriz, int n, int m)
{
    float** Tmatriz =  new float* [m];

	//Inicializar matriz
	for (size_t i = 0; i < m; i++)
	{
		Tmatriz[i] = new float [n];
	}

	//Transponer matriz
	for (size_t i = 0; i < m; i++)
	{
		for (size_t j = 0; j < n; j++)
		{
			Tmatriz[i][j] = matriz[j][i];
		}
	}

	cout << "Matriz transpuesta:" << endl;

	//Imprimir matris transpuesta
	for (size_t i = 0; i < m; i++)
	{
		for (size_t j = 0; j < n; j++)
		{
			cout << Tmatriz[i][j] << " ";
		}
		cout << endl;
	}

	return Tmatriz;
}

int main()
{
	int n = 3;
	int m = 7;

	float** matriz = new float* [n];

	for (size_t i = 0; i < n; i++)
	{
		matriz[i] = new float[m];
	}

	cout << "Matriz Original:" << endl;

	for (size_t i = 0; i < n; i++)
	{
		for (size_t j = 0; j < m; j++)
		{
			matriz[i][j] = rand() % 100 + 1;
			cout << matriz[i][j] << " ";
		}
		cout << endl;
	}

	cout << endl;

	transponer(matriz, n, m);
}