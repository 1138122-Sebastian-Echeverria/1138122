#include <iostream>
using namespace std;

void incremento(int length, int* array, int* datos)
{

	for (size_t i = 0; i < length; i++)
	{
		*(datos + i) = array[i];
	}

}

void imprimir(int* array, int largo)
{
	for (size_t o = 0; o < largo; o++)
	{
		cout << array[o] << endl;
	}
}

int main()
{

	int length = 2;
	int* arreglo1 = new int[length];
	cout << "Ingrese los numeros para su arreglo:" << endl;

	for (size_t i = 0; i <= length; i++)
	{
		cin >> *(arreglo1+i);

		if (i == length && *(arreglo1 + i) >= 0)
		{
			int* guardado = new int[length];

			incremento(length, arreglo1, guardado);

			length = length * 2;

			int* arreglo1 = new int[length];

			for (size_t o = 0; o < (length / 2); o++)
			{
				*(arreglo1 + o) = guardado[o];
			}
		}
		else if (arreglo1[i] < 0)
		{
			cout << " " << endl;

			cout << "Numeros del arreglo: " << endl;
			imprimir(arreglo1, length);

			cout << "Longitud final: " << length << endl;
			int cont = 0;

			for (size_t f = 0; f < length; f++)
			{

				if (arreglo1[f] < 0)
				{
					for (size_t j = 0; j < length; j++)
					{
						if (arreglo1[j] < 0)
						{
							cont = cont + 1;
							j = length;
							f = length;
						}
						
					}
					
				}
				else
				{
					cont = cont + 1;
				}
			}

			cout << "Valores Guardados: " << cont << endl;

			return 0;
		}
	}
}