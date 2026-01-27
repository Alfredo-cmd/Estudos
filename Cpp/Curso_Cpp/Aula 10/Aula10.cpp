#include <iostream>
#include <cstdlib>

using namespace std;

int main(){

    int n1, n2, res;
    char opc;

    inicio: //label que indica o inicio do goto

    system("clear");

    cout << "Digite o valor da sua primeira nota: \n";
    cin >> n1;

    cout << "Digite o valor da sua segunda nota: \n";
    cin >> n2;

    res = (n1 + n2)/2;

    if (res >= 7){
        cout << "Aprovado.\n\n";
    }
    else if (res >= 40)
    {
        cout << "Recuperação.\n\n";
    }
    else
    {
        cout << "Reprovado.\n\n";
    }

    cout << "Deseja usar novamente?: [s/n]\n";
    cin >> opc;

    if(opc=='s' or opc=='S')
    {
        goto inicio; //voltar pro label
    }

    return 0;
}