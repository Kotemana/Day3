using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForEachLoop();
            //Padiki(4, 5, 10);
            PadikiFancy(4, 15, 10);
            //MethodWithParams(5, "Hello World");
            //Scope();
        }

        static void ForLoop()
        {
            for (int j = 2; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i += 2)
                {
                    Console.Write($"{i} * {j} = {i * j} \t");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 34; i++)
            {
                if (i == 34)
                {
                    Console.WriteLine("I'm uncle Chernomor");
                }
                else
                {
                    Console.WriteLine($"I'm Bogatyr #{i}");
                }
            }
        }

        static void ForEachLoop()
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Porter";
            stringArray[1] = "Pilsner";
            stringArray[2] = "Wheat Beer";
            stringArray[3] = "Lager";
            stringArray[4] = "IPA";

            foreach (string beer in stringArray)
            {
                Console.Write(beer);
                if (beer == "Wheat Beer")
                {
                    Console.Write(" Fu bliat");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i == stringArray.Length - 1)
                {
                    Console.Write("And the last on out table ");
                }
                Console.WriteLine($"Beer #{i} is {stringArray[i]}");
            }
        }

        // Summary:
        //     There's a house with 5 padikis and 9 floors. Each floor has 3 flats
        //     We need to tell everyone which ligth to turn on (red or white)
        //     To show correct flag
        //     desired output: "Flat 1 - turn on white"...
        static void Padiki(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floors doesn't be lit");

            }
            else
            {
                Console.WriteLine("aLL flats work");
            }
            int flatnumber = 1;
            for (int padik = 1; padik <= padikiCount; padik++)
            {
                for (int floor = 1; floor <= floorCount; floor++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <=ostatok)
                        {
                            Console.WriteLine($"Flat{flatnumber} is off");
                        }
                        else
                        {
                            if (floor >=((floorCount - ostatok)/3*2 + ostatok-((floorCount - ostatok) / 3-1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.WriteLine($"Flat{flatnumber} is red");
                            }
                            else
                            {
                                Console.WriteLine($"Flat{flatnumber} is white");
                            }
                        }
                        flatnumber++;

                    }
                    
                }
            }
        }

        static void PadikiFancy(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit");

            }
            else
            {
                Console.WriteLine("aLL flats work");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            if (floor >= ((floorCount - ostatok) / 3 * 2 + ostatok - ((floorCount - ostatok) / 3 - 1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("*");
                            }
                        }
                        flatnumber++;

                    }

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void MethodWithParams(int number, string text)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Scope()
        {
            int x = 5;
            if (x > 3)
            {
                int z = 12;
                Console.WriteLine(x);
                Console.WriteLine(z);
            }
            Console.WriteLine(x);
            // Console.WriteLine(z); will not build: out of scope
        }
    }
}
