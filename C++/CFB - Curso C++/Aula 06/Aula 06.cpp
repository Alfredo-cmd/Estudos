#include <iostream>

using namespace std;

int n1, n2; //variaveis globais, funcionam em todas funções

int main(){

    //operadores matemáticos: + - / * % ()
    
    int n3, n4; //variaveis locais, funcionam apenas no main

    n1 = 11;
    n2 = 22;
    n3 = 5;
    n4 = 10;

    int res = n1 + n2 + n3 + n4;
    cout << "Adição de todas: " << res << "\n\n";


    return 0;
}