#include <iostream>
using namespace std;

void imp(string txt="Alfredo"); //texto padrão

int main(){

    imp();
    imp("Osvaldo");

    return 0;
}

void imp(string txt){

    cout << "\n" << txt << "\n\n";

}