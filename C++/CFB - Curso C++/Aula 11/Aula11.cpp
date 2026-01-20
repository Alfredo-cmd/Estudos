#include <iostream>
using namespace std;

int main(){

    int n1 = 8, n2 = 5;

    if (n1 > 4 && n1 < 7) // and
    {
        cout << "Verdadeiro!\n\n";
    }
    else
    {
        cout << "Falso!\n\n";
    }

    if (n2 > 4 || n2 > 7) // or
    {
        cout << "Verdadeiro!\n\n";
    }
    else
    {
        cout << "Falso!\n\n";
    }

    // tem como negar uma operação usando ! por exemplo em um if

    return 0;
}