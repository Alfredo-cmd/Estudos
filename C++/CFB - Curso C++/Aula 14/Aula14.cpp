#include <iostream>
#include <string>
using namespace std;

int main(){

    string i;
    while (true) // "Enquanto for falso, como eu nao coloco nenhuma forma de tornar ele falso ele vai ser infinito"
    {
        cout << "Oi!, vou falar isso até você digitar bloq rsrsrs\n";
        cin >> i;
        if (i == "bloq")
        {
            cout << "vtnc e .\n\n";
            break; // Porém eu quebro o loop quando a string for igual a "bloq"
        }
    }



    return 0;
}