#include "Texto.h"
using namespace std;

//getLength()
int Texto::getLength()
{
	return cadena.length();
}

//contains(char c)
bool Texto::contains(char c)
{

	for (int i = 0; i < getLength(); i++)
	{
		if (c == cadena[i])
		{
			return true;
		}
		else if (i = (getLength() - 1))
		{
			return false;
		}
	}
}

//contains(char c, int a)
bool Texto::contains(char c, int a)
{
	int n = 0;
	for (int i = 0; i < getLength(); i++)
	{
		

		if (c == cadena[i])
		{
			n++;
		}
	}

	if (n >= a)
	{
		return true;
	}
	else
	{
		return false;
	}
}

//reverse()
string reverseR(string texto, int i = 0)
{
	if (i == texto.length()) {
			return "";
		}
		else {
			// Llamada recursiva para invertir la parte restante de la cadena
			string reversed = reverseR(texto, i + 1);

			// Agregamos el carácter actual al final de la cadena invertida
			return reversed + texto[i];
		}
}

string Texto::reverse() 
{
	return reverseR(cadena);
}

//palindromo()
bool PalindromoR(const string S,int inicio, int fin) 
{
	if (inicio >= fin) {
		return true; // Caso base: cadena de longitud 0 o 1, es palíndromo
	}

	if (S[inicio] != S[fin]) {
		return false; // Los caracteres no coinciden, no es palíndromo
	}

	// Llamada recursiva para verificar el siguiente par de caracteres
	return PalindromoR(S, inicio + 1, fin - 1);
}

bool Texto::palindromo()
{
	// aaa -> palindromo
	// abba -> palindromo
	// abcccccccba -> palindromo
	return PalindromoR(cadena, 0, cadena.length()-1);
}

//toCharArray
char* caracter(string cad, int a)
{
	char* Car = new char[a];

	for (int i = 0; i < a; i++)
	{
		Car[i] = cad[i];
	}

	return Car;
}

char* Texto::toCharArray()
{
	return caracter(cadena, cadena.length());
}