#include <iostream>
using namespace std;

int Factorial(int n)
{
    if (n == 1) return 1;
    
    return n * Factorial(n - 1);
}

int Fibonacci(int n)
{
    if (n == 1) return 0;
    if (n == 1) return 1;
    int f1 = Fibonacci(n - 1);
    int f2 = Fibonacci(n - 2);
    return f1 + f2;
}

int main()
{
    int f5 = Factorial(5);

    int f3 = Fibonacci(10);

    cout << f3 << endl;

    cout << f5 << endl;

    return 0;

}
