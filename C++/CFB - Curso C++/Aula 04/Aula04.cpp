#include <iostream>
#include <string>

using namespace std;

int main(){

    //tipo e nome da variavel;
    //tipo, nome e valor da variavel;

    int vidas = 0; //números inteiros
    float decimal = 2.5; //2.5
    char letra = 'a'; //'8', 'a'
    char letras[20]; //uma forma de aumentar o limite de caractéres 
    bool vivo = true; //true or false
    string nome = "Alfredo"; //frases, textos, palavras ex: Alfredo


    cout << "Digite o número de vidas: ";
    cin >> vidas; //equivalente do input no Python
    cout <<"\n" << vidas << "\n" << decimal << "\n"; //posso por dessa forma também pra economizar linhas
    cout << letra << "\n";
    cout << vivo << "\n";
    cout << nome << "\n";



    return 0;
}