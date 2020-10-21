using System;
using System.Net.Security;

namespace SUDOKU___ARRENKA
{
    class Program
    {
        //Level 1
        public static int[,] arr = {
            { 0, 3, 5,  0, 0, 2,  9, 0, 0 },
            { 9, 0, 6,  0, 3, 1,  2, 0, 0 },
            { 7, 2, 8,  0, 0, 9,  6, 1, 3 },

            { 3, 0, 7,  0, 0, 0,  0, 9, 6 },
            { 6, 0, 0,  0, 0, 7,  0, 3, 0 },
            { 0, 0, 0,  3, 0, 6,  0, 4, 5 },

            { 2, 0, 9,  0, 0, 5,  3, 7, 0 },
            { 5, 8, 1,  0, 0, 0,  4, 0, 9 },
            { 0, 0, 0,  0, 2, 8,  5, 0, 0 }
        };
        public static int[,] arr1 = {
            { 1, 3, 5,  6, 7, 2,  9, 8, 4 },
            { 9, 4, 6,  8, 3, 1,  2, 5, 7 },
            { 7, 2, 8,  5, 4, 9,  6, 1, 3 },

            { 3, 5, 7,  2, 8, 4,  1, 9, 6 },
            { 6, 9, 4,  1, 5, 7,  8, 3, 2 },
            { 8, 1, 2,  3, 9, 6,  7, 4, 5 },

            { 2, 6, 9,  4, 1, 5,  3, 7, 8 },
            { 5, 8, 1,  7, 6, 3,  4, 2, 9 },
            { 4, 7, 3,  9, 2, 8,  5, 6, 1 }
        };
        // Level 2
        public static int[,] sdd = {
            { 5, 6, 0,  0, 2, 9,  4, 7, 3 },
            { 4, 2, 9,  3, 0, 0,  0, 0, 1 },
            { 3, 0, 8,  5, 0, 0,  0, 0, 9 },

            { 0, 0, 5,  6, 0, 0,  8, 1, 0 },
            { 0, 0, 2,  7, 0, 0,  0, 9, 0 },
            { 1, 0, 0,  0, 8, 0,  3, 5, 0 },

            { 0, 1, 3,  0, 0, 5,  0, 2, 8 },
            { 0, 5, 7,  0, 0, 8,  9, 0, 6 },
            { 0, 8, 0,  0, 0, 6,  1, 0, 0 }
        };
        public static int[,] sdd1 = {
            { 5, 6, 1,  8, 2, 9,  4, 7, 3 },
            { 4, 2, 9,  3, 6, 7,  5, 8, 1 },
            { 3, 7, 8,  5, 1, 4,  2, 6, 9 },

            { 7, 4, 5,  6, 9, 3,  8, 1, 2 },
            { 8, 3, 2,  7, 5, 1,  6, 9, 4 },
            { 1, 9, 6,  4, 8, 2,  3, 5, 7 },

            { 6, 1, 3,  9, 4, 5,  7, 2, 8 },
            { 2, 5, 7,  1, 3, 8,  9, 4, 6 },
            { 9, 8, 4,  2, 7, 6,  1, 3, 5 }
        };
        // Level 3
        public static int[,] asdd = {
            { 3, 0, 8,  0, 0, 0,  9, 0, 0 },
            { 4, 0, 9,  7, 0, 3,  0, 8, 0 },
            { 5, 6, 1,  9, 0, 8,  3, 0, 4 },

            { 0, 0, 5,  0, 0, 0,  0, 1, 8 },
            { 8, 0, 0,  1, 5, 0,  4, 9, 0 },
            { 1, 0, 0,  2, 0, 0,  0, 0, 3 },

            { 9, 8, 4,  6, 0, 2,  5, 3, 0 },
            { 0, 5, 7,  0, 0, 0,  6, 0, 9 },
            { 0, 0, 0,  0, 4, 0,  8, 0, 0 }
        };
        public static int[,] asdd1 = {
            { 3, 7, 8,  4, 1, 5,  9, 6, 2 },
            { 4, 2, 9,  7, 6, 3,  1, 8, 5 },
            { 5, 6, 1,  9, 2, 8,  3, 7, 4 },

            { 7, 4, 5,  3, 9, 6,  2, 1, 8 },
            { 8, 3, 2,  1, 5, 7,  4, 9, 6 },
            { 1, 9, 6,  2, 8, 4,  7, 5, 3 },

            { 9, 8, 4,  6, 7, 2,  5, 3, 1 },
            { 2, 5, 7,  8, 3, 1,  6, 4, 9 },
            { 6, 1, 3,  5, 4, 9,  8, 2, 7 }
        };
        //Level 1
        static int chois1;
        static int chois2;
        static int chois3;
        static int chois4;
        static int chois5;
        static int chois6;
        static int chois7;
        static int chois8;
        static int chois9;

        static int count = 0;
        
        // Level 2
        static int x1;
        static int x2;
        static int x3;
        static int x4;
        static int x5;
        static int x6;
        static int x7;
        static int x8;
        static int x9;
        
        static int count1 = 0;

        // Level 3
        static int zx1;
        static int zx2;
        static int zx3;
        static int zx4;
        static int zx5;
        static int zx6;
        static int zx7;
        static int zx8;
        static int zx9;

        static int count3 = 0;
        //Level 1
        private static void board()
        {
            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[0, 0]} | {arr[0, 1]} | {arr[0, 2]} |\t| {arr[0, 3]} | {arr[0, 4]} | {arr[0, 5]} |\t| {arr[0, 6]} | {arr[0, 7]} | {arr[0, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[1, 0]} | {arr[1, 1]} | {arr[1, 2]} |\t| {arr[1, 3]} | {arr[1, 4]} | {arr[1, 5]} |\t| {arr[1, 6]} | {arr[1, 7]} | {arr[1, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[2, 0]} | {arr[2, 1]} | {arr[2, 2]} |\t| {arr[2, 3]} | {arr[2, 4]} | {arr[2, 5]} |\t| {arr[2, 6]} | {arr[2, 7]} | {arr[2, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[3, 0]} | {arr[3, 1]} | {arr[3, 2]} |\t| {arr[3, 3]} | {arr[3, 4]} | {arr[3, 5]} |\t| {arr[3, 6]} | {arr[3, 7]} | {arr[3, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[4, 0]} | {arr[4, 1]} | {arr[4, 2]} |\t| {arr[4, 3]} | {arr[4, 4]} | {arr[4, 5]} |\t| {arr[4, 6]} | {arr[4, 7]} | {arr[4, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[5, 0]} | {arr[5, 1]} | {arr[5, 2]} |\t| {arr[5, 3]} | {arr[5, 4]} | {arr[5, 5]} |\t| {arr[5, 6]} | {arr[5, 7]} | {arr[5, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[6, 0]} | {arr[6, 1]} | {arr[6, 2]} |\t| {arr[6, 3]} | {arr[6, 4]} | {arr[6, 5]} |\t| {arr[6, 6]} | {arr[6, 7]} | {arr[6, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[7, 0]} | {arr[7, 1]} | {arr[7, 2]} |\t| {arr[7, 3]} | {arr[7, 4]} | {arr[7, 5]} |\t| {arr[7, 6]} | {arr[7, 7]} | {arr[7, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {arr[8, 0]} | {arr[8, 1]} | {arr[8, 2]} |\t| {arr[8, 3]} | {arr[8, 4]} | {arr[8, 5]} |\t| {arr[8, 6]} | {arr[8, 7]} | {arr[8, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");
        }

        // Level 2
        private static void board1()
        {
            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[0, 0]} | {sdd[0, 1]} | {sdd[0, 2]} |\t| {sdd[0, 3]} | {sdd[0, 4]} | {sdd[0, 5]} |\t| {sdd[0, 6]} | {sdd[0, 7]} | {sdd[0, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[1, 0]} | {sdd[1, 1]} | {sdd[1, 2]} |\t| {sdd[1, 3]} | {sdd[1, 4]} | {sdd[1, 5]} |\t| {sdd[1, 6]} | {sdd[1, 7]} | {sdd[1, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[2, 0]} | {sdd[2, 1]} | {sdd[2, 2]} |\t| {sdd[2, 3]} | {sdd[2, 4]} | {sdd[2, 5]} |\t| {sdd[2, 6]} | {sdd[2, 7]} | {sdd[2, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[3, 0]} | {sdd[3, 1]} | {sdd[3, 2]} |\t| {sdd[3, 3]} | {sdd[3, 4]} | {sdd[3, 5]} |\t| {sdd[3, 6]} | {sdd[3, 7]} | {sdd[3, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[4, 0]} | {sdd[4, 1]} | {sdd[4, 2]} |\t| {sdd[4, 3]} | {sdd[4, 4]} | {sdd[4, 5]} |\t| {sdd[4, 6]} | {sdd[4, 7]} | {sdd[4, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[5, 0]} | {sdd[5, 1]} | {sdd[5, 2]} |\t| {sdd[5, 3]} | {sdd[5, 4]} | {sdd[5, 5]} |\t| {sdd[5, 6]} | {sdd[5, 7]} | {sdd[5, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[6, 0]} | {sdd[6, 1]} | {sdd[6, 2]} |\t| {sdd[6, 3]} | {sdd[6, 4]} | {sdd[6, 5]} |\t| {sdd[6, 6]} | {sdd[6, 7]} | {sdd[6, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[7, 0]} | {sdd[7, 1]} | {sdd[7, 2]} |\t| {sdd[7, 3]} | {sdd[7, 4]} | {sdd[7, 5]} |\t| {sdd[7, 6]} | {sdd[7, 7]} | {sdd[7, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {sdd[8, 0]} | {sdd[8, 1]} | {sdd[8, 2]} |\t| {sdd[8, 3]} | {sdd[8, 4]} | {sdd[8, 5]} |\t| {sdd[8, 6]} | {sdd[8, 7]} | {sdd[8, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");
        }

        // Level 3
        private static void board3()
        {
            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[0, 0]} | {asdd[0, 1]} | {asdd[0, 2]} |\t| {asdd[0, 3]} | {asdd[0, 4]} | {asdd[0, 5]} |\t| {asdd[0, 6]} | {asdd[0, 7]} | {asdd[0, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[1, 0]} | {asdd[1, 1]} | {asdd[1, 2]} |\t| {asdd[1, 3]} | {asdd[1, 4]} | {asdd[1, 5]} |\t| {asdd[1, 6]} | {asdd[1, 7]} | {asdd[1, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[2, 0]} | {asdd[2, 1]} | {asdd[2, 2]} |\t| {asdd[2, 3]} | {asdd[2, 4]} | {asdd[2, 5]} |\t| {asdd[2, 6]} | {asdd[2, 7]} | {asdd[2, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[3, 0]} | {asdd[3, 1]} | {asdd[3, 2]} |\t| {asdd[3, 3]} | {asdd[3, 4]} | {asdd[3, 5]} |\t| {asdd[3, 6]} | {asdd[3, 7]} | {asdd[3, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[4, 0]} | {asdd[4, 1]} | {asdd[4, 2]} |\t| {asdd[4, 3]} | {asdd[4, 4]} | {asdd[4, 5]} |\t| {asdd[4, 6]} | {asdd[4, 7]} | {asdd[4, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[5, 0]} | {asdd[5, 1]} | {asdd[5, 2]} |\t| {asdd[5, 3]} | {asdd[5, 4]} | {asdd[5, 5]} |\t| {asdd[5, 6]} | {asdd[5, 7]} | {asdd[5, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|\n");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[6, 0]} | {asdd[6, 1]} | {asdd[6, 2]} |\t| {asdd[6, 3]} | {asdd[6, 4]} | {asdd[6, 5]} |\t| {asdd[6, 6]} | {asdd[6, 7]} | {asdd[6, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[7, 0]} | {asdd[7, 1]} | {asdd[7, 2]} |\t| {asdd[7, 3]} | {asdd[7, 4]} | {asdd[7, 5]} |\t| {asdd[7, 6]} | {asdd[7, 7]} | {asdd[7, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");

            Console.WriteLine("|   |   |   |\t|   |   |   |\t|   |   |   |");
            Console.WriteLine($"| {asdd[8, 0]} | {asdd[8, 1]} | {asdd[8, 2]} |\t| {asdd[8, 3]} | {asdd[8, 4]} | {asdd[8, 5]} |\t| {asdd[8, 6]} | {asdd[8, 7]} | {asdd[8, 8]} |");
            Console.WriteLine("|___|___|___|\t|___|___|___|\t|___|___|___|");
        }


        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                int result;

                if (int.TryParse(Console.ReadLine(), out result))
                    return result;

                else
                    Console.WriteLine("Sorry, it's not a correct integer value, please try again.");
            }
        }
        // Level 1====================================================================================================================================================
        public static void Level1()
        {
            do                                               // 1 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 1");
                Console.WriteLine("\n");
                board();
                chois1 = ReadInt(Console.ReadLine());
             
                    if (chois1 == arr1[0, 0])
                    {
                        arr[0, 0] = arr1[0, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                    if (arr[0, 0] == arr1[0, 0])
                    {
                        if (chois1 == arr1[1, 1])
                        {
                            arr[1, 1] = arr1[1, 1];
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                        }
                    }

                    if (arr[0, 0] == arr1[0, 0] && arr[1, 1] == arr1[1, 1])
                    {
                        chois1 = 0;
                        count++;
                    }
            } while (chois1 != 0);
            do                                            // 2 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 2");
                Console.WriteLine("\n");
                board();
                chois2 = ReadInt(Console.ReadLine());

                if (chois2 == arr1[0, 3])
                {
                    arr[0, 3] = arr1[0, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[0, 3] == arr1[0, 3])
                {
                    if (chois2 == arr1[0, 4])
                    {
                        arr[0, 4] = arr1[0, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[0, 4] == arr1[0, 4])
                {
                    if (chois2 == arr1[1, 3])
                    {
                        arr[1, 3] = arr1[1, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[1, 3] == arr1[1, 3])
                {
                    if (chois2 == arr1[2, 3])
                    {
                        arr[2, 3] = arr1[2, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[2, 3] == arr1[2, 3])
                {
                    if (chois2 == arr1[2, 4])
                    {
                        arr[2, 4] = arr1[2, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }


                if (arr[0, 3] == arr1[0, 3] && arr[0, 4] == arr1[0, 4] && arr[1, 3] == arr1[1, 3] && arr[2, 3] == arr1[2, 3] && arr[2, 4] == arr1[2, 4])
                {
                    chois2 = 0;
                    count++;
                }
            } while (chois2 != 0);

            do                                             // block 3 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 3");

                Console.WriteLine("\n");
                board();
                chois3 = ReadInt(Console.ReadLine());

                if (chois3 == arr1[0, 7])
                {
                    arr[0, 7] = arr1[0, 7];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[0, 7] == arr1[0, 7])
                {
                    if (chois3 == arr1[0, 8])
                    {
                        arr[0, 8] = arr1[0, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[0, 8] == arr1[0, 8])
                {
                    if (chois3 == arr1[1, 7])
                    {
                        arr[1, 7] = arr1[1, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[1, 7] == arr1[1, 7])
                {
                    if (chois3 == arr1[1, 8])
                    {
                        arr[1, 8] = arr1[1, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[0, 7] == arr1[0, 7] && arr[0, 8] == arr1[0, 8] && arr[1, 7] == arr1[1, 7] && arr[1, 8] == arr1[1, 8])
                {
                    chois3 = 0;
                    count++;
                }

            } while (chois3 != 0);

            do                                            // block 4 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 4");

                Console.WriteLine("\n");
                board();
                chois4 = ReadInt(Console.ReadLine());



                if (chois4 == arr1[3, 1])
                {
                    arr[3, 1] = arr1[3, 1];
                }
                else
                {
                    Console.WriteLine("Try again");
                }

                if (arr[3, 1] == arr1[3, 1])
                {
                    if (chois4 == arr1[4, 1])
                    {
                        arr[4, 1] = arr1[4, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 1] == arr1[4, 1])
                {
                    if (chois4 == arr1[4, 2])
                    {
                        arr[4, 2] = arr1[4, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 2] == arr1[4, 2])
                {
                    if (chois4 == arr1[5, 0])
                    {
                        arr[5, 0] = arr1[5, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[5, 0] == arr1[5, 0])
                {
                    if (chois4 == arr1[5, 1])
                    {
                        arr[5, 1] = arr1[5, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[5, 1] == arr1[5, 1])
                {
                    if (chois4 == arr1[5, 2])
                    {
                        arr[5, 2] = arr1[5, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[3, 1] == arr1[3, 1] && arr[4, 1] == arr1[4, 1] && arr[4, 2] == arr1[4, 2] && arr[5, 0] == arr1[5, 0] && arr[5, 1] == arr1[5, 1] && arr[5, 2] == arr1[5, 2])
                {
                    chois4 = 0;
                    count++;
                }
            } while (chois4 != 0);

            do                                        // block 5 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 5");

                Console.WriteLine("\n");
                board();
                chois5 = ReadInt(Console.ReadLine());

                if (chois5 == arr1[3, 3])
                {
                    arr[3, 3] = arr1[3, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[3, 3] == arr1[3, 3])
                {
                    if (chois5 == arr1[3, 4])
                    {
                        arr[3, 4] = arr1[3, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[3, 4] == arr1[3, 4])
                {
                    if (chois5 == arr1[3, 5])
                    {
                        arr[3, 5] = arr1[3, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[3, 5] == arr1[3, 5])
                {
                    if (chois5 == arr1[4, 3])
                    {
                        arr[4, 3] = arr1[4, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 3] == arr1[4, 3])
                {
                    if (chois5 == arr1[4, 4])
                    {
                        arr[4, 4] = arr1[4, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 4] == arr1[4, 4])
                {
                    if (chois5 == arr1[5, 4])
                    {
                        arr[5, 4] = arr1[5, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[3, 3] == arr1[3, 3] && arr[3, 4] == arr1[3, 4] && arr[3, 5] == arr1[3, 5] && arr[4, 3] == arr1[4, 3] && arr[4, 4] == arr1[4, 4] && arr[5, 4] == arr1[5, 4])
                {
                    chois5 = 0;
                    count++;
                }

            } while (chois5 != 0);

            do                                    // block 6 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 6");

                Console.WriteLine("\n");
                board();
                chois6 = ReadInt(Console.ReadLine());

                if (chois6 == arr1[3, 6])
                {
                    arr[3, 6] = arr1[3, 6];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[3, 6] == arr1[3, 6])
                {
                    if (chois6 == arr1[4, 6])
                    {
                        arr[4, 6] = arr1[4, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 6] == arr1[4, 6])
                {
                    if (chois6 == arr1[4, 8])
                    {
                        arr[4, 8] = arr1[4, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[4, 8] == arr1[4, 8])
                {
                    if (chois6 == arr1[5, 6])
                    {
                        arr[5, 6] = arr1[5, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[3, 6] == arr1[3, 6] && arr[4, 6] == arr1[4, 6] && arr[4, 8] == arr1[4, 8] && arr[5, 6] == arr1[5, 6])
                {
                    chois6 = 0;
                    count++;
                }

            } while (chois6 != 0);
            do                                           //  block 7 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 7");

                Console.WriteLine("\n");
                board();
                chois7 = ReadInt(Console.ReadLine());

                if (chois7 == arr1[6, 1])
                {
                    arr[6, 1] = arr1[6, 1];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[6, 1] == arr1[6, 1])
                {
                    if (chois7 == arr1[8, 0])
                    {
                        arr[8, 0] = arr1[8, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[8, 0] == arr1[8, 0])
                {
                    if (chois7 == arr1[8, 1])
                    {
                        arr[8, 1] = arr1[8, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[8, 1] == arr1[8, 1])
                {
                    if (chois7 == arr1[8, 2])
                    {
                        arr[8, 2] = arr1[8, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[6, 1] == arr1[6, 1] && arr[8, 0] == arr1[8, 0] && arr[8, 0] == arr1[8, 0] && arr[8, 1] == arr1[8, 1] && arr[8, 2] == arr1[8, 2])
                {
                    chois7 = 0;
                    count++;
                }
            } while (chois7 != 0);

            do                                                // block 8 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 8");

                Console.WriteLine("\n");
                board();
                chois8 = ReadInt(Console.ReadLine());

                if (chois8 == arr1[6, 3])
                {
                    arr[6, 3] = arr1[6, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[6, 3] == arr1[6, 3])
                {
                    if (chois8 == arr1[6, 4])
                    {
                        arr[6, 4] = arr1[6, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[6, 4] == arr1[6, 4])
                {
                    if (chois8 == arr1[7, 3])
                    {
                        arr[7, 3] = arr1[7, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[7, 3] == arr1[7, 3])
                {
                    if (chois8 == arr1[7, 4])
                    {
                        arr[7, 4] = arr1[7, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[7, 4] == arr1[7, 4])
                {
                    if (chois8 == arr1[7, 5])
                    {
                        arr[7, 5] = arr1[7, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[7, 5] == arr1[7, 5])
                {
                    if (chois8 == arr1[8, 3])
                    {
                        arr[8, 3] = arr1[8, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (arr[6, 3] == arr1[6, 3] && arr[6, 4] == arr1[6, 4] && arr[7, 3] == arr1[7, 3] && arr[7, 4] == arr1[7, 4] && arr[7, 5] == arr1[7, 5] && arr[8, 3] == arr1[8, 3])
                {
                    chois8 = 0;
                    count++;
                }
            } while (chois8 != 0);

            do                                      // block 9 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 1");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 9");

                Console.WriteLine("\n");
                board();
                chois9 = ReadInt(Console.ReadLine());

                if (chois9 == arr1[6, 8])
                {
                    arr[6, 8] = arr1[6, 8];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (arr[6, 8] == arr1[6, 8])
                {
                    if (chois9 == arr1[7, 7])
                    {
                        arr[7, 7] = arr1[7, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[7, 7] == arr1[7, 7])
                {
                    if (chois9 == arr1[8, 7])
                    {
                        arr[8, 7] = arr1[8, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[8, 7] == arr1[8, 7])
                {
                    if (chois9 == arr1[8, 8])
                    {
                        arr[8, 8] = arr1[8, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (arr[6, 8] == arr1[6, 8] && arr[7, 7] == arr1[7, 7] && arr[8, 7] == arr1[8, 7] && arr[8, 8] == arr1[8, 8])
                {
                    chois9 = 0;
                    count++;
                }
            } while (chois9 != 0);
            Console.Clear();
            board();

            if (count == 9)
            {

                Console.WriteLine("YOU WON!!!");
                Console.WriteLine("Next Level");
            }
            Console.ReadLine();

        }
        // Level 2
        //+++++++++=====================================================================+++++++++++++++++++++++++++++++++++=======================================
        public static void Level2()
        {
            do                                               // 1 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 1");
                Console.WriteLine("\n");
                board1();


                x1 = ReadInt(Console.ReadLine());


                if (x1 == sdd1[0, 2])
                {
                    sdd[0, 2] = sdd1[0, 2];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[0, 2] == sdd1[0, 2])
                {
                    if (x1 == sdd1[2, 1])
                    {
                        sdd[2, 1] = sdd1[2, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[0, 2] == sdd1[0, 2] && sdd[2, 1] == sdd1[2, 1])
                {
                    x1 = 0;
                    count1++;
                }

            } while (x1 != 0);

            do                                            // 2 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 2");
                Console.WriteLine("\n");
                board1();
                x2 = ReadInt(Console.ReadLine());

                if (x2 == sdd1[0, 3])
                {
                    sdd[0, 3] = sdd1[0, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[0, 3] == sdd1[0, 3])
                {
                    if (x2 == sdd1[1,4])
                    {
                        sdd[1, 4] = sdd1[1, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[1, 4] == sdd1[1, 4])
                {
                    if (x2 == sdd1[1, 5])
                    {
                        sdd[1, 5] = sdd1[1, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[1, 5] == sdd1[1, 5])
                {
                    if (x2 == sdd1[2, 4])
                    {
                        sdd[2, 4] = sdd1[2, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[2, 4] == sdd1[2, 4])
                {
                    if (x2 == sdd1[2, 5])
                    {
                        sdd[2, 5] = sdd1[2, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[0, 3] == sdd1[0, 3] && sdd[1, 4] == sdd1[1, 4] && sdd[1, 5] == sdd1[1, 5] && sdd[2, 4] == sdd1[2, 4] && sdd[2, 5] == sdd1[2, 5])
                {
                    x2 = 0;
                    count1++;
                }
            } while (x2 != 0);

            do                                             // block 3 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 3");

                Console.WriteLine("\n");
                board1();
                x3 = ReadInt(Console.ReadLine());

                if (x3 == sdd1[1, 6])
                {
                    sdd[1, 6] = sdd1[1, 6];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[1, 6] == sdd1[1, 6])
                {
                    if (x3 == sdd1[1, 7])
                    {
                        sdd[1, 7] = sdd1[1, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[1, 7] == sdd1[1, 7])
                {
                    if (x3 == sdd1[2, 6])
                    {
                        sdd[2, 6] = sdd1[2, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[2, 6] == sdd1[2, 6])
                {
                    if (x3 == sdd1[2, 7])
                    {
                        sdd[2, 7] = sdd1[2, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[1, 6] == sdd1[1, 6] && sdd[1, 7] == sdd1[1, 7] && sdd[2, 6] == sdd1[2, 6] && sdd[2, 7] == sdd1[2, 7])
                {
                    x3 = 0;
                    count1++;
                }

            } while (x3 != 0);

            do                                            // block 4 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 4");

                Console.WriteLine("\n");
                board1();
                x4 = ReadInt(Console.ReadLine());

                if (x4 == sdd1[3, 0])
                {
                    sdd[3, 0] = sdd1[3, 0];
                }
                else
                {
                    Console.WriteLine("Try again");
                }

                if (sdd[3, 0] == sdd1[3, 0])
                {
                    if (x4 == sdd1[3, 1])
                    {
                        sdd[3, 1] = sdd1[3, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[3, 1] == sdd1[3, 1])
                {
                    if (x4 == sdd1[4, 0])
                    {
                        sdd[4, 0] = sdd1[4, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 0] == sdd1[4, 0])
                {
                    if (x4 == sdd1[4, 1])
                    {
                        sdd[4, 1] = sdd1[4, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 1] == sdd1[4, 1])
                {
                    if (x4 == sdd1[5, 1])
                    {
                        sdd[5, 1] = sdd1[5, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[5, 1] == sdd1[5, 1])
                {
                    if (x4 == sdd1[5, 2])
                    {
                        sdd[5, 2] = sdd1[5, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[3, 0] == sdd1[3, 0] && sdd[3, 1] == sdd1[3, 1] && sdd[4, 0] == sdd1[4, 0] && sdd[4, 1] == sdd1[4, 1] && sdd[5, 1] == sdd1[5, 1] && sdd[5, 2] == sdd1[5, 2])
                {
                    x4 = 0;
                    count1++;
                }
            } while (x4 != 0);

            do                                        // block 5 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 5");

                Console.WriteLine("\n");
                board1();
                x5 = ReadInt(Console.ReadLine());

                if (x5 == sdd1[3, 4])
                {
                    sdd[3, 4] = sdd1[3, 4];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[3, 4] == sdd1[3, 4])
                {
                    if (x5 == sdd1[3, 5])
                    {
                        sdd[3, 5] = sdd1[3, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[3, 5] == sdd1[3, 5])
                {
                    if (x5 == sdd1[4, 4])
                    {
                        sdd[4, 4] = sdd1[4, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 4] == sdd1[4, 4])
                {
                    if (x5 == sdd1[4, 5])
                    {
                        sdd[4, 5] = sdd1[4, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 5] == sdd1[4, 5])
                {
                    if (x5 == sdd1[5, 3])
                    {
                        sdd[5, 3] = sdd1[5, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[5, 3] == sdd1[5, 3])
                {
                    if (x5 == sdd1[5, 5])
                    {
                        sdd[5, 5] = sdd1[5, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[3, 4] == sdd1[3, 4] && sdd[3, 5] == sdd1[3, 5] && sdd[4, 4] == sdd1[4, 4] && sdd[4, 5] == sdd1[4, 5] && sdd[5, 3] == sdd1[5, 3] && sdd[5, 5] == sdd1[5, 5])
                {
                    x5 = 0;
                    count1++;
                }

            } while (x5 != 0);

            do                                    // block 6 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 6");

                Console.WriteLine("\n");
                board1();
                x6 = ReadInt(Console.ReadLine());

                if (x6 == sdd1[3, 8])
                {
                    sdd[3, 8] = sdd1[3, 8];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[3, 8] == sdd1[3, 8])
                {
                    if (x6 == sdd1[4, 6])
                    {
                        sdd[4, 6] = sdd1[4, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 6] == sdd1[4, 6])
                {
                    if (x6 == sdd1[4, 8])
                    {
                        sdd[4, 8] = sdd1[4, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[4, 8] == sdd1[4, 8])
                {
                    if (x6 == sdd1[5, 8])
                    {
                        sdd[5, 8] = sdd1[5, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[3, 8] == sdd1[3, 8] && sdd[4, 6] == sdd1[4, 6] && sdd[4, 8] == sdd1[4, 8] && sdd[5, 8] == sdd1[5, 8])
                {
                    x6 = 0;
                    count1++;
                }

            } while (x6 != 0);
            do                                           //  block 7 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 7");

                Console.WriteLine("\n");
                board1();
                x7 = ReadInt(Console.ReadLine());

                if (x7 == sdd1[6, 0])
                {
                    sdd[6, 0] = sdd1[6, 0];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[6, 0] == sdd1[6, 0])
                {
                    if (x7 == sdd1[7, 0])
                    {
                        sdd[7, 0] = sdd1[7, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[7, 0] == sdd1[7, 0])
                {
                    if (x7 == sdd1[8, 0])
                    {
                        sdd[8, 0] = sdd1[8, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[8, 0] == sdd1[8, 0])
                {
                    if (x7 == sdd1[8, 2])
                    {
                        sdd[8, 2] = sdd1[8, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[6, 0] == sdd1[6, 0] && sdd[7, 0] == sdd1[7, 0] && sdd[8, 0] == sdd1[8, 0] && sdd[8, 2] == sdd1[8, 2])
                {
                    x7 = 0;
                    count1++;
                }
            } while (x7 != 0);

            do                                                // block 8 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 8");

                Console.WriteLine("\n");
                board1();
                x8 = ReadInt(Console.ReadLine());

                if (x8 == sdd1[6, 3])
                {
                    sdd[6, 3] = sdd1[6, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[6, 3] == sdd1[6, 3])
                {
                    if (x8 == sdd1[6, 4])
                    {
                        sdd[6, 4] = sdd1[6, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[6, 4] == sdd1[6, 4])
                {
                    if (x8 == sdd1[7, 3])
                    {
                        sdd[7, 3] = sdd1[7, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[7, 3] == sdd1[7, 3])
                {
                    if (x8 == sdd1[7, 4])
                    {
                        sdd[7, 4] = sdd1[7, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[7, 4] == sdd1[7, 4])
                {
                    if (x8 == sdd1[8, 3])
                    {
                        sdd[8, 3] = sdd1[8, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[8, 3] == sdd1[8, 3])
                {
                    if (x8 == sdd1[8, 4])
                    {
                        sdd[8, 4] = sdd1[8, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (sdd[6, 3] == sdd1[6, 3] && sdd[6, 4] == sdd1[6, 4] && sdd[7, 3] == sdd1[7, 3] && sdd[7, 4] == sdd1[7, 4] && sdd[8, 3] == sdd1[8, 3] && sdd[8, 4] == sdd1[8, 4])
                {
                    x8 = 0;
                    count1++;
                }
            } while (x8 != 0);

            do                                      // block 9 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 2");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 9");

                Console.WriteLine("\n");
                board1();
                x9 = ReadInt(Console.ReadLine());

                if (x9 == sdd1[6, 6])
                {
                    sdd[6, 6] = sdd1[6, 6];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (sdd[6, 6] == sdd1[6, 6])
                {
                    if (x9 == sdd1[7, 7])
                    {
                        sdd[7, 7] = sdd1[7, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[7, 7] == sdd1[7, 7])
                {
                    if (x9 == sdd1[8, 7])
                    {
                        sdd[8, 7] = sdd1[8, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[8, 7] == sdd1[8, 7])
                {
                    if (x9 == sdd1[8, 8])
                    {
                        sdd[8, 8] = sdd1[8, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (sdd[6, 6] == sdd1[6, 6] && sdd[7, 7] == sdd1[7, 7] && sdd[8, 7] == sdd1[8, 7] && sdd[8, 8] == sdd1[8, 8])
                {
                    x9 = 0;
                    count1++;
                }
            } while (x9 != 0);
            Console.Clear();
            board1();

            if (count1 == 9)
            {

                Console.WriteLine("YOU WON!!!");
                Console.WriteLine("Next Level");
            }
            Console.ReadLine();

        }
        // Level 3
        //+++++++++=====================================================================+++++++++++++++++++++++++++++++++++=======================================
        public static void Level3()
        {
            do                                               // 1 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 1");
                Console.WriteLine("\n");
                board3();
                zx1 = ReadInt(Console.ReadLine());

                if (zx1 == asdd1[0, 1])
                {
                    asdd[0, 1] = asdd1[0, 1];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[0, 1] == asdd1[0, 1])
                {
                    if (zx1 == asdd1[1, 1])
                    {
                        asdd[1, 1] = asdd1[1, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[0, 1] == asdd1[0, 1] && asdd[1, 1] == asdd1[1, 1])
                {
                    zx1 = 0;
                    count3++;
                }

            } while (zx1 != 0);

            do                                            // 2 block 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 2");
                Console.WriteLine("\n");
                board3();
                zx2 = ReadInt(Console.ReadLine());

                if (zx2 == asdd1[0, 3])
                {
                    asdd[0, 3] = asdd1[0, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[0, 3] == asdd1[0, 3])
                {
                    if (zx2 == asdd1[0, 4])
                    {
                        asdd[0, 4] = asdd1[0, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[0, 4] == asdd1[0, 4])
                {
                    if (zx2 == asdd1[0, 5])
                    {
                        asdd[0, 5] = asdd1[0, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[0, 5] == asdd1[0, 5])
                {
                    if (zx2 == asdd1[1, 4])
                    {
                        asdd[1, 4] = asdd1[1, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[1, 4] == asdd1[1, 4])
                {
                    if (zx2 == asdd1[2, 4])
                    {
                        asdd[2, 4] = asdd1[2, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[0, 3] == asdd1[0, 3] && asdd[0, 4] == asdd1[0, 4] && asdd[0, 5] == asdd1[0, 5] && 
                    asdd[1, 4] == asdd1[1, 4] && asdd[2, 4] == asdd1[2, 4])
                {
                    zx2 = 0;
                    count3++;
                }
            } while (zx2 != 0);

            do                                             // block 3 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 3");

                Console.WriteLine("\n");
                board3();
                zx3 = ReadInt(Console.ReadLine());

                if (zx3 == asdd1[0, 7])
                {
                    asdd[0, 7] = asdd1[0, 7];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[0, 7] == asdd1[0, 7])
                {
                    if (zx3 == asdd1[0, 8])
                    {
                        asdd[0, 8] = asdd1[0, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[0, 8] == asdd1[0, 8])
                {
                    if (zx3 == asdd1[1, 6])
                    {
                        asdd[1, 6] = asdd1[1, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[1, 6] == asdd1[1, 6])
                {
                    if (zx3 == asdd1[1, 8])
                    {
                        asdd[1, 8] = asdd1[1, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[1, 8] == asdd1[1, 8])
                {
                    if (zx3 == asdd1[2, 7])
                    {
                        asdd[2, 7] = asdd1[2, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[0, 7] == asdd1[0, 7] && asdd[0, 8] == asdd1[0, 8] && asdd[1, 6] == asdd1[1, 6] && 
                    asdd[1, 8] == asdd1[1, 8] && asdd[2, 7] == asdd1[2, 7])
                {
                    zx3 = 0;
                    count3++;
                }

            } while (zx3 != 0);

            do                                            // block 4 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 4");

                Console.WriteLine("\n");
                board3();
                zx4 = ReadInt(Console.ReadLine());

                if (zx4 == asdd1[3, 0])
                {
                    asdd[3, 0] = asdd1[3, 0];
                }
                else
                {
                    Console.WriteLine("Try again");
                }

                if (asdd[3, 0] == asdd1[3, 0])
                {
                    if (zx4 == asdd1[3, 1])
                    {
                        asdd[3, 1] = asdd1[3, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[3, 1] == asdd1[3, 1])
                {
                    if (zx4 == asdd1[4, 1])
                    {
                        asdd[4, 1] = asdd1[4, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[4, 1] == asdd1[4, 1])
                {
                    if (zx4 == asdd1[4, 2])
                    {
                        asdd[4, 2] = asdd1[4, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[4, 2] == asdd1[4, 2])
                {
                    if (zx4 == asdd1[5, 1])
                    {
                        asdd[5, 1] = asdd1[5, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[5, 1] == asdd1[5, 1])
                {
                    if (zx4 == asdd1[5, 2])
                    {
                        asdd[5, 2] = asdd1[5, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[3, 0] == asdd1[3, 0] && asdd[3, 1] == asdd1[3, 1] && asdd[4, 1] == asdd1[4, 1] 
                    && asdd[4, 2] == asdd1[4, 2] && asdd[5, 1] == asdd1[5, 1] && asdd[5, 2] == asdd1[5, 2])
                {
                    zx4 = 0;
                    count3++;
                }
            } while (zx4 != 0);

            do                                        // block 5 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 5");

                Console.WriteLine("\n");
                board3();
                zx5 = ReadInt(Console.ReadLine());

                if (zx5 == asdd1[3, 3])
                {
                    asdd[3, 3] = asdd1[3, 3];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[3, 3] == asdd1[3, 3])
                {
                    if (zx5 == asdd1[3, 4])
                    {
                        asdd[3, 4] = asdd1[3, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[3, 4] == asdd[3, 4])
                {
                    if (zx5 == asdd1[3, 5])
                    {
                        asdd[3, 5] = asdd1[3, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[3, 5] == asdd1[3, 5])
                {
                    if (zx5 == asdd1[4, 5])
                    {
                        asdd[4, 5] = asdd1[4, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[4, 5] == asdd1[4, 5])
                {
                    if (zx5 == asdd1[5, 4])
                    {
                        asdd[5, 4] = asdd1[5, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[5, 4] == asdd1[5, 4])
                {
                    if (zx5 == asdd1[5, 5])
                    {
                        asdd[5, 5] = asdd1[5, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[3, 3] == asdd1[3, 3] && asdd[3, 4] == asdd1[3, 4] && asdd[3, 5] == asdd1[3, 5] && 
                    asdd[4, 5] == asdd1[4, 5] && asdd[5, 4] == asdd1[5, 4] && asdd[5, 5] == asdd1[5, 5])
                {
                    zx5 = 0;
                    count3++;
                }

            } while (zx5 != 0);

            do                                    // block 6 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 6");

                Console.WriteLine("\n");
                board3();
                zx6 = ReadInt(Console.ReadLine());

                if (zx6 == asdd1[3, 6])
                {
                    asdd[3, 6] = asdd1[3, 6];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[3, 6] == asdd1[3, 6])
                {
                    if (zx6 == asdd1[4, 8])
                    {
                        asdd[4, 8] = asdd1[4, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[4, 8] == asdd1[4, 8])
                {
                    if (zx6 == asdd1[5, 6])
                    {
                        asdd[5, 6] = asdd1[5, 6];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[5, 6] == asdd1[5, 6])
                {
                    if (zx6 == asdd1[5, 7])
                    {
                        asdd[5, 7] = asdd1[5, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[3, 6] == asdd1[3, 6] && asdd[4, 8] == asdd1[4, 8] && asdd[5, 6] == asdd1[5, 6] && 
                    asdd[5, 7] == asdd1[5, 7])
                {
                    zx6 = 0;
                    count3++;
                }

            } while (zx6 != 0);
            do                                           //  block 7 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 7");

                Console.WriteLine("\n");
                board3();
                zx7 = ReadInt(Console.ReadLine());

                if (zx7 == asdd1[7, 0])
                {
                    asdd[7, 0] = asdd1[7, 0];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[7, 0] == asdd1[7, 0])
                {
                    if (zx7 == asdd1[8, 0])
                    {
                        asdd[8, 0] = asdd1[8, 0];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[8, 0] == asdd1[8, 0])
                {
                    if (zx7 == asdd1[8, 1])
                    {
                        asdd[8, 1] = asdd1[8, 1];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[8, 1] == asdd1[8, 1])
                {
                    if (zx7 == asdd1[8, 2])
                    {
                        asdd[8, 2] = asdd1[8, 2];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[7, 0] == asdd1[7, 0] && asdd[8, 0] == asdd1[8, 0] && asdd[8, 1] == asdd1[8, 1] && 
                    asdd[8, 2] == asdd1[8, 2])
                {
                    zx7 = 0;
                    count3++;
                }
            } while (zx7 != 0);

            do                                                // block 8 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 8");

                Console.WriteLine("\n");
                board3();
                zx8 = ReadInt(Console.ReadLine());
                if (zx8 == asdd1[6, 4])
                {
                    asdd[6, 4] = asdd1[6, 4];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[6, 4] == asdd1[6, 4])
                {
                    if (zx8 == asdd1[7, 3])
                    {
                        asdd[7, 3] = asdd1[7, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[7, 3] == asdd1[7, 3])
                {
                    if (zx8 == asdd1[7, 4])
                    {
                        asdd[7, 4] = asdd1[7, 4];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[7, 4] == asdd1[7, 4])
                {
                    if (zx8 == asdd1[7, 5])
                    {
                        asdd[7, 5] = asdd1[7, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[7, 5] == asdd1[7, 5])
                {
                    if (zx8 == asdd1[8, 3])
                    {
                        asdd[8, 3] = asdd1[8, 3];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[8, 3] == asdd1[8, 3])
                {
                    if (zx8 == asdd1[8, 5])
                    {
                        asdd[8, 5] = asdd1[8, 5];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (asdd[6, 4] == asdd1[6, 4] && asdd[7, 3] == asdd1[7, 3] && asdd[7, 4] == asdd1[7, 4] && 
                    asdd[7, 5] == asdd1[7, 5] && asdd[8, 3] == asdd1[8, 3] && asdd[8, 5] == asdd1[8, 5])
                {
                    zx8 = 0;
                    count3++;
                }
            } while (zx8 != 0);

            do                                      // block 9 3x3
            {
                Console.Clear();
                Console.WriteLine("Level 3");
                Console.WriteLine("Please enter the value 2 times, thank you");
                Console.WriteLine("Game 9");

                Console.WriteLine("\n");
                board3();
                zx9 = ReadInt(Console.ReadLine());

                if (zx9 == asdd1[6, 8])
                {
                    asdd[6, 8] = asdd1[6, 8];
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                if (asdd[6, 8] == asdd1[6, 8])
                {
                    if (zx9 == asdd1[7, 7])
                    {
                        asdd[7, 7] = asdd1[7, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[7, 7] == asdd1[7, 7])
                {
                    if (zx9 == asdd1[8, 7])
                    {
                        asdd[8, 7] = asdd1[8, 7];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[8, 7] == asdd1[8, 7])
                {
                    if (zx9 == asdd1[8, 8])
                    {
                        asdd[8, 8] = asdd1[8, 8];
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                if (asdd[6, 8] == asdd1[6, 8] && asdd[7, 7] == asdd1[7, 7] && asdd[8, 7] == asdd1[8, 7] && 
                    asdd[8, 8] == asdd1[8, 8])
                {
                    zx9 = 0;
                    count3++;
                }
            } while (zx9 != 0);
            Console.Clear();
            board3();

            if (count3 == 9)
            {

                Console.WriteLine("YOU WON!!!");
              
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Level1();
            Level2();
            Level3();
        }
    }
}
