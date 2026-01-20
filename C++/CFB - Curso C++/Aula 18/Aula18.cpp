#include <iostream>
using namespace std;

int main()
{
    int tam = 5;
    int vetor[tam]={10,20,30,40,50}; // basicamente uma variavel que pode receber 10 valores respectivos as suas posições

    

    int x;
    for (x=0; x < tam ; x++) // to feliz em ter pensado nessa possibilidade sozinho
    {
        cout << vetor[x] << "\n";
    }

    return 0;
}