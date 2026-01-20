#include <iostream>
#include <cstdlib>
using namespace std;

int main(){

    int n1, n2;
    char escolha, escolha2;

    inicio: //goto caso o usúario queira usar novamente
    system("clear");
    //Bem vindo
    cout << "Bem vindo a calculadora!\n\n";
    
    //Funções
    cout << "Você terá as seguintes funções: \n";
    cout << "Adição[a] \n";
    cout << "Subtração[s] \n";
    cout << "Multiplicação[m] \n";
    cout << "Divisão[d] \n\n";

    //Primeiro número
    cout << "Agora, por favor digite o primeiro número: ";
    cin >> n1;

    //Segundo número
    cout << "Agora, por favor digite o segundo número: ";
    cin >> n2;

    errada: //Goto caso caia no default
    cout << "\n\nQual operação você deseja fazer?: ";
    cin >> escolha;

    switch(escolha){
        case 'A':
        case 'a':
            cout << "Resultado: " << n1 << " + " << n2 << " = " << n1 + n2 << "\n\n";
            break;
        case 'S':
        case 's':
            cout << "Resultado: " << n1 << " - " << n2 << " = " << n1 - n2 << "\n\n";
            break;
        case 'M':
        case 'm':
            cout << "Resultado: " << n1 << " x " << n2 << " = " << n1 * n2 << "\n\n";
            break;
        case 'D':
        case 'd':
            if (n2 != 0)
            {
                cout << "Resultado: " << n1 << " / " << n2 << " = " << n1 / n2 << "\n\n";
            }
            else
            {
                cout << "Por favor, não divida por 0. \n\n";
                goto inicio;
            }
            break;
        default:
            cout << "Por favor digite uma resposta válida.\n";
            goto errada;
            break;
    }

    cout << "Deseja usar o programa novamente?: ";
    cin >> escolha2;
    if (escolha2 == 's' || escolha2 == 'S')
    {
        goto inicio;
    }
    

    return 0;
}