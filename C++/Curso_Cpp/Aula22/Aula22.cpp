#include <iostream>
#include <string>

using namespace std;

void texto();
void soma(int n1, int n2);
int soma2 (int n1, int n2);
void tr(string tra[4]);


int main (){
    int res;
    string transp[4]={"carro","moto","barco","aviao"};


    res = soma2(175, 25);
    soma(7,3);
    tr(transp);

    cout << res << "\n";
    return 0;
}

void texto(){
    cout << "Alfredo Alves Filho\n";

}

void soma(int n1, int n2){
    cout << n1 << " + " <<  n2 << " = " << n1+n2 <<"\n\n";
}

int soma2 (int n1, int n2){
    return n1+n2;
}

void tr(string tra[4]){
    for (int i=0; i<4; i++){
        cout << tra[i] << "\n";
    }
}