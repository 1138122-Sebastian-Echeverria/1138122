#include "Texto.h"
using namespace std;

int Texto::getLength()
{
	return cadena.length();
}

bool Texto::contains(char c)
{

	for (int i = 0; i < getLength(); i++)
	{
		if (c = cadena[i])
		{
			return true;
		}
		else if (i = (getLength() - 1))
		{
			return false;
		}
	}
}

bool Texto::contains(char c, int a)
{
	int n = 0;
	for (int i = 0; i < getLength(); i++)
	{
		

		if (c = cadena[i])
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

bool palindromoR()
{
	

	return true || false;
}

bool palindromo()
{
	// aaa -> palindromo
	// abba -> palindromo
	// abcccccccba -> palindromo
	return palindromoR();
}

char* Texto::toCharArray()
{
	return new char[0];
}