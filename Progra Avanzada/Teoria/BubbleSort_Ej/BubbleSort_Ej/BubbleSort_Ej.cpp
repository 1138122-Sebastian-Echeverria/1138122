#include <iostream>
using namespace std;

void BubbleSort(int* b, int longitud)
{
	for (int i = 0; i < longitud; i++)
	{
		for (int j = i+1; j < longitud; j++)
		{
			if (b[i] > b[j])
			{
				int t = b[j];
				b[j] = b[i];
				b[i] = t;
			}
		}
	}
}

void InsertionSort(int * b, int longitud)
{
	for (int i = 1; i < longitud; i++) //ciclo que recorre los datos a ordenar
	{
		int k = b[i]; // resguardamos el valor a orenar en K
		int vi = i - 1; //iniciamos la posicion o a evaluar para saber si K debe estar ahi
		while (b[vi] > k && vi >= 0) //seguimos buscando posiciones para K
		{
			b[vi + 1] = b[vi]; //desplazar los valores de cada posicion explorada a la derecha (a posiciones mayores)
			vi = vi - 1; 
		}
		b[vi + 1] = k; //ya hemos encontrado la posicion que debe ocupar K => vi + 1
	}
}


int main()
{
	int * b = new int [8] {6, 2, 1, 3, 6, 0, -1, 5};

	for (int i = 0; i < 8; i++)
	{
		cout << b[i] << " ";
	}

	cout << endl << "Bubble Sort" << endl;
	BubbleSort(b, 8);

	for (int i = 0; i < 8; i++)
	{
		cout << b[i] << " ";
	}

	cout << endl << "Insertion Sort" << endl;
	
	b = new int[8] {6, 2, 1, 3, 6, 0, -1, 5};
	InsertionSort(b, 8);

	for (int i = 0; i < 8; i++)
	{
		cout << b[i] << " ";
	}
}