#include "Iniciar.h"
#include <iostream>
#include <queue>
#include <stack>
#include <cstdlib>
#include <time.h>

int Iniciar::Empezar()
{
	int x;
	srand(time(0));
	x = 10 + rand() % (100);

	return x;
}