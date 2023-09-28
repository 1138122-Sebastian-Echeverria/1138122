#include <iostream>
#include <string>
using namespace std;
char* caracter(string cad, int a)
{
	char* Car = new char[a];

	for (int i = 0; i < a; i++)
	{
		Car[i] = cad[i];
		cout << Car[i]<< endl;
	}

	return Car;
}

int main() {
    string cadena = "mamahueve";

    cout << caracter(cadena, cadena.length()) << endl;


    return 0;
}