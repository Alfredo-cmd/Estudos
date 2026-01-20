#include <iostream>

using namespace std;

int main(){


    int num=10;
    cout << num << "\n\n";

    //num = num * -1; forma tradicional de inverter a variavel pra ficar negativa


    //cout << -num << "\n\n"; inverte apenas na hora de imprimir


    num=-num; //melhor forma de inverter
    cout << num << "\n\n";

    return 0;
}