#include <iostream>
using namespace std;
//Sebastian Echeverria Flores 1138122

float** normalize(float** matriz, int n, int m)
{
    cout << "Matriz Original:" << endl;
    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            cout << matriz[i][j] << endl;
        }
    }

    cout << endl;

    //Encontrar el numero menor
    float num = matriz[0][0];
    float vmin = matriz[0][0];
    float vmax = 0;

    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            if (num > matriz[i][j])
            {
                num = matriz[i][j];
                vmin = matriz[i][j];
            }
        }
    }

    cout << "Numero menor: " << vmin << endl;

    cout << endl;

    //Encontrar el numero mayor
    num = matriz[0][0];

    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            if (num < matriz[i][j])
            {
                num = matriz[i][j];
                vmax = matriz[i][j];
            }
        }
    }

    cout << "Numero mayor: " << vmax << endl;

    cout << endl;

    //Diferencia dmm
    float dmm = vmax - vmin;

    //Remplazo de valores v con dn
    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            num = matriz[i][j];
            if (vmin != matriz[i][j] && vmax != matriz[i][j])
            {
                num = (num - vmin) / dmm;
                matriz[i][j] = num;

            }
        }
    }

    cout << "Matriz con dn:" << endl;
    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            cout << matriz[i][j] << endl;
        }
    }

    return matriz;
};



int main()
{

    int n = 3;
    int m = 4;
    float** matriz = new float* [n];

    for (size_t i = 0; i < n; i++)
    {
        matriz[i] = new float[m];
    }

    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            matriz[i][j] = rand();
        }
    }

    normalize(matriz, n, m);
}
