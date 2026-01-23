#include <iostream>
#include <stack>


using namespace std;

int main(){

    stack <string> cartas;

    cartas.push("Rei de Copas");
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouro");
    cartas.push("Rei de Paus"); //Ultimo a entrar, primeiro a sair

    cout << "Tamanho da pilha: " << cartas.size() << "\n";

    cout << "Carta do topo: " << cartas.top() << "\n";
    
    cartas.pop();

    cout << "Nova carta do topo: " << cartas.top() << "\n";

    cartas.pop();

    cout << "Nova carta do topo: " << cartas.top() << "\n";

    cartas.pop();

    cout << "Nova carta do topo: " << cartas.top() << "\n";

    return 0;
}