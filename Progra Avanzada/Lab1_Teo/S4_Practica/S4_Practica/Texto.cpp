#include "Texto.h"

int Texto::getLength()
{

	return cadena.length();
}

bool Texto::contains(char c)
{

	for (int i = 0; i < cadena.length(); i++)
	{
		if (c = cadena[i])
		{
			return true;
		}
		else if (i = (cadena.length() - 1))
		{
			return false;
		}
	}
}

bool Texto::contains(char c, int a)
{
	return false || true;
}

string reverseR()
{
	//Logica recursiva
}

string Texto::reverse() 
{
	//Recursiva
	//abcd -> dcba

	return reverseR("abcd");
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