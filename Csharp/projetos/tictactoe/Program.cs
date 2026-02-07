using System;
class TicTacToe
{
    static void Main()
    {
        char [,] Board = CreateBoard();
        char player = 'X';
        char input;
        int player_turn = 0;
        bool win_game;
        int draw = 0;

        

        do
        {
            Console.Clear();
            if(player_turn == 0)
            {
                player = 'X';
                player_turn = 1;
            }
            else if(player_turn == 1)
            {
                player = 'O';
                player_turn = 0;
            }
            BoardPrint(Board);
            input = GameInput(player);
            draw++;
            BoardUpdate(Board, input, player);
            win_game = GameOver(Board);
            if(draw == 9)
            {
                Console.WriteLine("Empate");
            }
        }
        while(win_game == false && draw != 9);
        BoardPrint(Board);
    }

    static char[,] CreateBoard()
    {
        char [,] board = new char[3,3];
        int value = 1;


        for (int i = 0; i<3; i++)
        {
            for (int j = 0; j<3; j++)
            {
                board[i,j] =(char) ('1' +(value-1));
                value++;
            }
        }
        return board;
    }

    static void BoardPrint(char [,] PrintBoard)
    {
        for (int i = 0; i<3; i++)
        {
            for (int j = 0; j<3; j++)
            {
                Console.Write($"[{PrintBoard[i, j]}]");
            }
            Console.WriteLine("");
        }
    }


    static void BoardUpdate(char [,] boardUpdate, char input, char Player)
    {
        
        int pos = input - '1';
        if (pos < 0 || pos > 8)
            return;
        int l = pos / 3;
        int c = pos % 3;

        if(boardUpdate[l,c] != 'X' && boardUpdate[l,c] != 'O')
        {
            boardUpdate.SetValue(Player, l,c);
        }
    }

    //----------------------------------------------------------------

    static char GameInput(char Player)
    {
        Console.Write($"Jogador {Player} Digite o número que representa a posição (1 a 9): ");
        return char.Parse(Console.ReadLine());
    }

    static bool GameOver(char[,] board_win)
    {
        bool win = false;
        //horizontais
        if(board_win[0,0] == 'X' && board_win[0,1] == 'X' && board_win[0,2] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        else if(board_win[1,0] == 'X' && board_win[1,1] == 'X' && board_win[1,2] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        else if(board_win[2,0] == 'X' && board_win[2,1] == 'X' && board_win[2,2] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        
        //diagonais
        else if(board_win[1,1] == 'X' && board_win[0,0] == 'X' && board_win[2,2] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        else if(board_win[0,2] == 'X' && board_win[1,1] == 'X' && board_win[2,0] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }

        //verticais
        else if(board_win[0,0] == 'X' && board_win[1,0] == 'X' && board_win[2,0] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        else if(board_win[0,1] == 'X' && board_win[1,1] == 'X' && board_win[2,1] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        else if(board_win[0,2] == 'X' && board_win[1,2] == 'X' && board_win[2,2] == 'X')
        {
            win = true;
            Console.WriteLine("O jogador X venceu!");
        }
        //Jogador O
        else if(board_win[0,0] == 'O' && board_win[0,1] == 'O' && board_win[0,2] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        else if(board_win[1,0] == 'O' && board_win[1,1] == 'O' && board_win[1,2] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        else if(board_win[2,0] == 'O' && board_win[2,1] == 'O' && board_win[2,2] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        
        //diagonais
        else if(board_win[1,1] == 'O' && board_win[0,0] == 'O' && board_win[2,2] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        else if(board_win[0,2] == 'O' && board_win[1,1] == 'O' && board_win[2,0] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }

        //verticais
        else if(board_win[0,0] == 'O' && board_win[1,0] == 'O' && board_win[2,0] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        else if(board_win[0,1] == 'O' && board_win[1,1] == 'O' && board_win[2,1] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }
        else if(board_win[0,2] == 'O' && board_win[1,2] == 'O' && board_win[2,2] == 'O')
        {
            win = true;
            Console.WriteLine("O jogador O venceu!");
        }

        return win;
    }

}