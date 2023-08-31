#include <iostream>
using namespace std;

float** Sum(float** matriz1, float** matriz2, int n, int m)
{
    float** SumaM = new float*[n];

    for (size_t i = 0; i < n; i++)
    {
            SumaM[i] = new float[m];
    }

    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            SumaM[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }

    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            cout << "[" << SumaM[i][j] << "]" << endl;
        }
    }

    return SumaM;
}

int main()
{

    int n = 3;
    int m = 4;
    float** matriz1 = new float*[n];
    float** matriz2 = new float*[n];

    for (size_t i = 0; i < n; i++)
    {
        matriz1[i] = new float[m];
        matriz2[i] = new float[m];
    }
    
    for (size_t i = 0; i < n; i++)
    {
        for (size_t j = 0; j < m; j++)
        {
            matriz1[i][j] = rand();
            matriz2[i][j] = rand();
        }
    }

    Sum(matriz1, matriz2, n, m);
}