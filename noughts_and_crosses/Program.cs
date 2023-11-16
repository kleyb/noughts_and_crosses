using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1input = 0;
            int player2input = 0;
            bool win = false;
            bool res;
            bool valid;
            bool valid2 = false;
            bool res2 = false;
            //Array created 
            string[,] challenge =  { {"1","2","3"},
                                     {"4","5","6"},
                                     {"7","8","9"} };
            //While win isn't true, the code will run - While no Player wins the game , the code will run
            do
            {
                //Console.WriteLine(Winner(win, challenge));
                do
                {
                    //Displays the Array
                    Console.Clear();
                    Table(challenge);
                    Console.WriteLine("Player 1 : Choose your field");
                    string player1string = Console.ReadLine();
                    res = int.TryParse(player1string, out player1input);
                    Player1Choice(player1input, player2input, challenge);
                    if (player1input > 9 || player1input < 1)
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                    win = Winner(win, challenge);

                } while (res == false || valid == false);

                if (win)
                {
                    Console.Clear();
                    Table(challenge);
                    break;
                }
                do
                {
                    Console.Clear();
                    //Displays the Array
                    Table(challenge);

                    Console.WriteLine("Player 2 : Choose your field");
                    string player2string = Console.ReadLine();
                    res2 = int.TryParse(player2string, out player2input);
                    Player2Choice(player1input, player2input, challenge);
                    if (player2input > 9 || player2input < 1)
                    {
                        valid2 = false;
                    }
                    else
                    {
                        valid2 = true;
                    }
                    win = Winner(win, challenge);
                } while (res2 == false || valid2 == false);

                Console.Clear();
            } while (win == false);
            Console.Clear();
            Table(challenge);
            Console.WriteLine("Congratulations , you have won the game");

            static bool Winner(bool win, string[,] challenge)
            {
                for (int i = 0; i < 3; ++i)
                {
                    if (challenge[i, 0].Equals("O") && challenge[i, 1].Equals("O") && challenge[i, 2].Equals("O"))
                    {
                        return (win = true);
                    }
                    else if (challenge[0, i].Equals("O") && challenge[1, i].Equals("O") && challenge[2, i].Equals("O"))
                    {
                        return (win = true);
                    }
                    else if (challenge[0, 0].Equals("O") && challenge[1, 1].Equals("O") && challenge[2, 2].Equals("O"))
                    {
                        return (win = true);
                    }
                    else if (challenge[2, 0].Equals("O") && challenge[1, 1].Equals("O") && challenge[0, 2].Equals("O"))
                    {
                        return (win = true);
                    }
                    else if (challenge[i, 0].Equals("X") && challenge[i, 1].Equals("X") && challenge[i, 2].Equals("X"))
                    {
                        return (win = true);
                    }
                    else if (challenge[0, i].Equals("X") && challenge[1, i].Equals("X") && challenge[2, i].Equals("X"))
                    {
                        return (win = true);
                    }
                    else if (challenge[0, 0].Equals("X") && challenge[1, 1].Equals("X") && challenge[2, 2].Equals("X"))
                    {
                        return (win = true);
                    }
                    else if (challenge[2, 0].Equals("X") && challenge[1, 1].Equals("X") && challenge[0, 2].Equals("X"))
                    {
                        return (win = true);
                    }


                }
                return win = false;
            }
            static void Player1Choice(int player1input, int player2input, string[,] challenge)
            {
                switch (player1input)
                {
                    case 1:
                        challenge[0, 0] = "O";
                        break;
                    case 2:
                        challenge[0, 1] = "O";
                        break;
                    case 3:
                        challenge[0, 2] = "O";
                        break;
                    case 4:
                        challenge[1, 0] = "O";
                        break;
                    case 5:
                        challenge[1, 1] = "O";
                        break;
                    case 6:
                        challenge[1, 2] = "O";
                        break;
                    case 7:
                        challenge[2, 0] = "O";
                        break;
                    case 8:
                        challenge[2, 1] = "O";
                        break;
                    case 9:
                        challenge[2, 2] = "O";
                        break;
                    default:
                        Console.WriteLine("The number you have selected is not valid");
                        break;
                }
            }

            static void Player2Choice(int player1input, int player2input, string[,] challenge)
            {
                switch (player2input)
                {
                    case 1:
                        challenge[0, 0] = "X";
                        break;
                    case 2:
                        challenge[0, 1] = "X";
                        break;
                    case 3:
                        challenge[0, 2] = "X";
                        break;
                    case 4:
                        challenge[1, 0] = "X";
                        break;
                    case 5:
                        challenge[1, 1] = "X";
                        break;
                    case 6:
                        challenge[1, 2] = "X";
                        break;
                    case 7:
                        challenge[2, 0] = "X";
                        break;
                    case 8:
                        challenge[2, 1] = "X";
                        break;
                    case 9:
                        challenge[2, 2] = "X";
                        break;
                    default:
                        Console.WriteLine("The number you have selected is not valid");
                        break;
                }
            }

            static void Table(string[,] challenge)
            {
                int rowLength = challenge.GetLength(0);
                int colLength = challenge.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(" {0} " + " | ", challenge[i, j]);
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
            }
            Console.ReadKey();
        }
    }
}
