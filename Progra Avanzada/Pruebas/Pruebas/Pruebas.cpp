#include <iostream>
#include <string>
using namespace std;

int f(int n) {
    if (n < 1) return 1;
    
    int result = 1;
    
    for (int i = 1; i <= n; ++i) {
        int a = result;
        int b = i / 2;
        int c = result;
        result = a * b + c;
    }
    
    return result;
}

int main() 
{
   
	cout << f(5);
}