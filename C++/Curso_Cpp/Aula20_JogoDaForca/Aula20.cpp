#include <iostream>
#include <string>
#include <cstdlib>
#include <cstring>


using namespace std;

int main()
{
    //variaveis
    int i, j, k, f, o = 0;   
    char tentativas, escolha;
    bool acertou, sair = true, vitoria = false;
    string palavra;
    

    do
    {
        system("clear");
        //input do usuario
        cout << "Digite alguma palavra!! [jogador 1]: ";
        getline(cin >> ws, palavra);
        system("clear");

        //variavel tamanho
        int tamanho = palavra.length();
        char certo[tamanho];
        int contagem = tamanho;
        for (k=0; k < tamanho; k++)
        {
            certo[k] = '_';
        }
    

        cout << "\n";
        for (i = 0; i < tamanho; i++)
            {
                cout << certo[i] << " ";
            }
        cout << "\n";
        vitoria = false;
        do
        {  
            acertou = false;
            cout << "Você tem " << contagem << " tentativas.\n\n";
            cout << "Digite alguma letra!: ";
            cin >> tentativas;
            for (j = 0; j < tamanho; j++)
            {
                if (tentativas == palavra[j])
                {
                    certo[j] = palavra[j];
                    cout << certo[j] << " ";
                    acertou = true;
                }
                else if(tentativas != palavra[j])
                {
                    cout << certo[j] << " ";
                }
            }
            if(acertou == false)
            {
                contagem --;
            }
            for (f = 0; f < tamanho ; f++)
            {
                if (certo[f] == '_')
                {
                    break;
                }
            }
            if (f == tamanho)
                {
                    vitoria = true;
                }
            cout << "\n";
                    
        } while (contagem > 0 && !vitoria);

        if (vitoria == true)
        {
            cout << "Você venceu!, deseja jogar novamente?: [s/n]";
            cin >> escolha;
            if (escolha == 's' || escolha == 'S')
            {
                sair = true;
            }
            else if (escolha == 'n' || escolha == 'N')
            {
                sair = false;
            }   
        }
        if (!vitoria)
        {
            cout << "Você perdeu!, deseja jogar novamente?: [s/n]";
            cin >> escolha;
            if (escolha == 's' || escolha == 'S')
            {
                sair = true;
            }
            else if (escolha == 'n' || escolha == 'N')
            {
                sair = false;
            }   
        }
    } while (sair == true);
    
    

    return 0;
}