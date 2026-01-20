#include <iostream>
#include <cstdlib>
using namespace std;

int main()
{
    int num = 0;
    char escolha;
    do
    {
        system("clear");
        cout << "Quer saber a tabuada de qual número?: ";
        cin >> num;
        int i;
        for(i = 0; i<11; i++)
        {

            cout << num << "x" << i << "=" << num*i << "\n";
        }
        cout << "[s/n] Deseja usar novamente?: ";
        cin >> escolha;
        if (escolha == 'n' || escolha == 'N')
        {
            break;
        }    
    }while(true);
    cout << "Obrigado por usar!\n\n";


    return 0;
}