#include <iostream>
using namespace std;

void soma(int n1,int n2);
void soma();

int main(){

    soma(10, 20);
    soma();

    return 0;
}
void soma(int n1,int n2){ //se tiver argumentos diferentes posso ter funções com mesmo nome
    n1=10;
    n2=20;
    int res=n1+n2;
    cout << "10 + 20 = " << res << "\n\n";
}

void soma(){

    int n1,n2,res;
    n1=10;
    n2=20;
    res=n1+n2;
    cout << "10 + 20 = " << res << "\n\n";
}