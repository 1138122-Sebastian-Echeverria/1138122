#pragma once
#include <iostream>
#include <string>
using namespace std;

class Texto
{
private:
	string cadena;

public:
	int getLength();
	bool contains(char c);
	bool contains(char c, int n);
	string reverse();
	bool palindromo();
	char* toCharArray();

	//constructor

	Texto(string _string)
	{
		cadena = _string;
		
	}
};

