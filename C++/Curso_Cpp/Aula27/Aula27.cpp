#include <iostream>
using namespace std;

int main(){

    //enum só inteiros, valor sequencial, por ex:
    //com fuzil valendo 100, revolver vai valer 101 etc
    enum armas{fuzil=100, revolver, rifle, escopeta};
    armas armaSel;

    armaSel=fuzil;

    cout << armaSel << "\n";

    return 0;
}