// SEF1138122_P2.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include <queue>
#include <stack>
#include <cstdlib>
#include <time.h>
#include "Iniciar.h"
using namespace std;


int main()
{
	int attempt = 1;
	Iniciar z;
	int n;
	queue<int> cola1;
	queue<int> cola2;
	int numero;

	while (attempt <= 3)
	{
		cout << "\x1B[2J\x1B[H";
		if (attempt > 1)
		{
			cout << "Intenta de nuevo" << endl;
		}
		cout << "Posibles respuestas:" << endl;

		for (int i = 0; i < 10; i++)
		{
			n = z.Empezar();
			cola1.push(n);
			if (i <= 8)
			{
				cout << n << ", ";
			}
			else
			{
				cout << n;
			}
		}
		cout << endl;

		int giros = z.Empezar();

		for (int i = 0; i < giros; i++)
		{
			cola2.push(cola1.front());
			cola1.pop();

			cola1.push(cola2.front());
			cola2.pop();
		}

		cout << "Intente adivinar el numero:" << endl;
		cin >> numero;

		if (numero == cola1.front())
		{
			cout << "Felicidades a adivinado.";
			attempt = 4;
		}
		else
		{
			cola1 = queue<int>();
			attempt++;

		}
	}
}