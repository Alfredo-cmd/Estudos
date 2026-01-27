#include <iostream>
#include <string>

using namespace std;

int main(){

    //(expressão) ? valor1 : valor2;

    int n1, n2, nota;
    string res;

    cout << "Digite a primeira nota: \n";
    cin >> n1;
    cout << "Digite a segunda nota: \n";
    cin >> n2;
    
    nota = n1 + n2;

    //>=60 aprovado
    //<60 reprovado

    //primeira forma(nota >= 60) ? res="Aprovado" : res="Reprovado";tipo um if soque mais prático para operações pequenas.

    res=(nota>=60) ? "Aprovado" : "Reprovado"; //segunda forma 
    cout << res << "\n\n"; 

    

    return 0;
}