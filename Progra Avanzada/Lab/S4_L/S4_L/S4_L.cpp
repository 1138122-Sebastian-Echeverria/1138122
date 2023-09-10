#include <iostream>
using namespace std;

//1) mcd
int mcd(int a, int b)
{
    if (a > b && b == 0) return a;

    return mcd(b, a % b);
}

//2) Triangulo de sumas
int triangulo(int* a, int n)
{
    int c = n - 1;
    if (c == 0)
    {
        return 1;
    }
    int* b = new int[c];

    cout << "[";
    for (int i = 0; i < c; i++)
    {
        b[i] = a[i] + a[i+1];
        if (i != c - 1)
        {
            cout << b[i] << ", ";
        }
        else
        {
            cout << b[i];
        }
    }
    cout << "] " << endl;
    cout << endl;
    return triangulo(b, c);
}

//3) Invertir arreglo
string reverse(string texto, int i = 0)
{
    if (i == texto.length()) {
        return "";
    }
    else {
        string reversed = reverse(texto, i + 1);

        return reversed + texto[i];
    }
}

//4) Contains
bool primo(int n, int divisor = 2) 
{
    if (n <= 1) {
        return false;
    }
    if (n == 2) {
        return true;
    }
    if (n % divisor == 0) {
        return false;
    }
    if (divisor * divisor > n) {
        return true;
    }
    return primo(n, divisor + 1);
}

//5) Iteracion
int f(int n)
{
    if (n < 1) return 1;

    int resultado = 1;

    for (int i = 2; i <= n; ++i) {
        resultado = resultado * (i / 2) + resultado;
    }

    return resultado;
}

int main()
{
    //mcd
    cout << "mcd:" << endl;
    
    //imprimir
    cout << mcd(4, 2) << endl;
    cout << endl;

    //triangulo de sumas
    cout << "Triangulo de sumas:" << endl;
    int n = 4;
    int* matriz1 = new int [3];

    //Inicializar matriz
    cout << "[";
    for (size_t i = 0; i < n; i++)
    {
        matriz1[i] = rand() % 100 + 1;

        if (i != n - 1)
        {
            cout << matriz1[i] << ", ";
        }
        else
        {
            cout << matriz1[i];
        }
    }
    cout << "] " << endl;
    cout << endl;
    triangulo(matriz1, n);
    cout << endl;

    //Invertir arreglo
    cout << "Invertir Arreglos:" << endl;
    cout << reverse("ABCD") << endl;
    cout << endl;

    //Contains (0 es falso, 1 es verdadero)
    cout << "Contains:" << endl;
    cout << primo(8) << endl;
    cout << endl;

    //Iteración
    cout << "Iteracion:" << endl;
    cout << f(5) << endl;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
