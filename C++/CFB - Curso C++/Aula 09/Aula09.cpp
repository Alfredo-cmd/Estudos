#include<iostream>

using namespace std;

int main(){


    int n1, n2;
    
    
    char escolha;


    cout << "Bem vindo a calculadora! \n Operações: \n Divisão (d), Multiplicação (m), Adição, (A), Subtração (S)\n\n\n\n";
    cout << "Digite um número: \n";
    cin >> n1;
    cout << "Digite outro número: \n";
    cin >> n2;
    int mult = n1*n2, div = n1/n2, adic = n1+n2, sub = n1-n2;

    cout << "Que operação matematica você desejar fazer? \n\n";
    cin >> escolha;

    if (escolha == 'd' || escolha == 'D'){
        if (n1 == 0 || n2 == 0){
            cout << "Por favor, não divida por 0.\n\n";
        }
        else{
            cout << n1 << "/" << n2 << "=" << div << "\n\n"; 
        }
    }
    else if (escolha == 'm' || escolha == 'M')
    {
        cout << n1 << "*" << n2 << "=" << mult << "\n\n";
    }
    else if (escolha == 'a' || escolha == 'A')
    {
        cout << n1 << "+" << n2 << "=" << adic << "\n\n";
    }
    else if (escolha == 's' || escolha == 'S')
    {
        cout << n1 << "-" << n2 << "=" << sub << "\n\n";
    }



    return 0;
}
