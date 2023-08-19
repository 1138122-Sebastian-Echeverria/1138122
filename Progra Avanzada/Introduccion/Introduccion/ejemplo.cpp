#include "ejemplo.h"
ejemplo::ejemplo() {

	edades = 10;
	presupuesto = 19.10;
};

int ejemplo::CalcularPresupuestoEdad(int edad, int multiplicar) {
	return edad * multiplicar;
}
