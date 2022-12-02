using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


class Program
{



    // !! >>>>>> Эта часть нужна чтобы сделать окно во весь экран. Не знаю как работает, просто нашел в интернете и перепечатал  <<<<<<<<<<<
    /**/
    /**/
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto),/* SetLastError = true*/]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    private const int MAXIMIZE = 3;
    /**/
    /**/
    // !! >>>>>> Эта часть нужна чтобы сделать окно во весь экран. Не знаю как работает, просто нашел в интернете и перепечатал  <<<<<<<<<<<


    static void Main(string[] args)
    {
        // !! >>>>>> Эта часть нужна чтобы сделать окно во весь экран. Не знаю как работает, просто нашел в интернете и перепечатал  <<<<<<<<<<<
        /**/
        /**/
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        ShowWindow(GetConsoleWindow(), MAXIMIZE);
        /**/
        /**/
        // !! >>>>>> Эта часть нужна чтобы сделать окно во весь экран. Не знаю как работает, просто нашел в интернете и перепечатал  <<<<<<<<<<<




        int[] results = new int[3];
        Console.Title = "Dice";

        Thread.Sleep(2000);

        for (int i = 0; i < 3; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(10 + i * 50, 1);
            Console.WriteLine("Введите число от 2 до 12");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Black;



            int throwCount = 1;
            int GAP_X = 14;
            int GAP_Y = 12;
            Thread.Sleep(2000);
            char press1 = Console.ReadKey().KeyChar;
            Console.SetCursorPosition(10 + i * 50, 1);
            Console.WriteLine("                            ");
            int myBet = Convert.ToInt32(press1 - 48);
            if (myBet == 1)
            {
                Console.SetCursorPosition(1, 1);
                press1 = Console.ReadKey().KeyChar;
                myBet = myBet * 10 + Convert.ToSByte(press1 - 48);
            }


            void Dice(int dice, bool compTurn)
            {
                void ColorComp(bool compTurn)
                {
                    if (compTurn == true) Console.BackgroundColor = ConsoleColor.DarkRed;
                    if (compTurn == false) Console.BackgroundColor = ConsoleColor.DarkBlue;

                }

                throwCount++;
                if (throwCount == 4)
                {
                    GAP_Y *= 2;
                    GAP_X = 14;
                    throwCount = 2;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                for (int j = 1; j <= dice; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("           ");

                    ColorComp(compTurn);
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("   |       ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("   |       ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("   |       ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("   |       ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("   |       ");
                    Console.Beep(300, 50);

                    Console.Beep(300, 50);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("           ");

                    ColorComp(compTurn);
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("     |     ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("     |     ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("     |     ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("     |     ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("     |     ");
                    Console.Beep(300, 50);


                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("           ");

                    ColorComp(compTurn);
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("      |    ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("      |    ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("      |    ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("      |    ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("      |    ");
                    Console.Beep(300, 50);


                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("           ");

                    ColorComp(compTurn);
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                    Console.WriteLine("        |  ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                    Console.WriteLine("        |  ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                    Console.WriteLine("        |  ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                    Console.WriteLine("        |  ");
                    Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                    Console.WriteLine("        |  ");


                    Console.Beep(300, 50);


                    switch (j)
                    {
                        case 1:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("     *     ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            break;


                        case 2:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            break;

                        case 3:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("  *        ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("     *     ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("        *  ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");

                            break;

                        case 4:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");


                            break;

                        case 5:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("     *     ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            break;


                        case 6:
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 3 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 4 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 5 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 6 + GAP_Y - 10);
                            Console.WriteLine("   *   *   ");
                            Console.SetCursorPosition(throwCount * GAP_X + (i * 50) - GAP_X, 7 + GAP_Y - 10);
                            Console.WriteLine("           ");
                            break;
                    }
                    Thread.Sleep(100);

                }
                Console.WriteLine();

            }


            Console.WriteLine();

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int compBet = random.Next(1, 13);
            int diceComp1 = random.Next(1, 7);
            int diceComp2 = random.Next(1, 7);




            int RatioDice(int dice) // Задаем коэффициент, выведенный опытным путем. Зависит от того какое выбрано число. Чем более редкое, тем выше коэффициент
            {
                return dice switch
                {
                    2 => 15,
                    3 => 13,
                    4 => 11,
                    5 => 9,
                    6 => 7,
                    7 => 8,
                    8 => 7,
                    9 => 9,
                    10 => 11,
                    11 => 13,
                    12 => 15,
                };
            }



            int resultPlayer = (RatioDice(myBet) - Math.Abs(myBet - Math.Abs(dice1 + dice2)) * 3);
            int resultComp = (RatioDice(compBet) - Math.Abs(compBet - Math.Abs(diceComp1 + diceComp2)) * 3);


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Dice(dice1, compTurn: false);
            Dice(dice2, compTurn: false);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(GAP_X + i * 50 - 5, GAP_Y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Ты загадал {myBet}, выбросил {dice1 + dice2} ({resultPlayer} очков):");



            Console.BackgroundColor = ConsoleColor.DarkRed;
            Dice(diceComp1, compTurn: true);
            Dice(diceComp2, compTurn: true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;


            Console.SetCursorPosition(GAP_X + i * 50 - 5, GAP_Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Комп загадал {compBet}, выбросил {diceComp1 + diceComp2} ({resultComp} очков):");



            Console.SetCursorPosition(20, 33 + i * 2);
            if (resultPlayer < resultComp) Console.WriteLine($"{i + 1}й кон. Ты проиграл со счетом {resultPlayer - resultComp}");
            if (resultPlayer > resultComp) Console.WriteLine($"{i + 1}й кон. Ты выиграл со счетом {resultPlayer - resultComp}");
            if (resultPlayer == resultComp) Console.WriteLine($"{i + 1}й кон. Ничья!");

            results[i] = resultPlayer - resultComp;

        }
        int generaResult = 0;
        foreach (int i in results) generaResult += i;


        Console.SetCursorPosition(22, 41);
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (generaResult < 0) Console.WriteLine($">> Ты проиграл! Итоговый счет: {generaResult} <<");
        if (generaResult > 0) Console.WriteLine($">> Ты выиграл! Итоговый счет: {generaResult} <<");
        if (generaResult == 0) Console.WriteLine($">> ничья! <<");
        Console.ForegroundColor = ConsoleColor.Black;

    }
}