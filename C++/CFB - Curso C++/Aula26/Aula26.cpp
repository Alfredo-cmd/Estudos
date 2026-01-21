#include <iostream>
using namespace std;

int main(){

    int val, res;
    val=8;
    res=fatorial(val);



    return 0;
}

int fatorial (int n){
    if(n==0){
        return 1;
    }
    return n*fatorial(n-1);
}