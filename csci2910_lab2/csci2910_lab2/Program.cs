/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: csci2910_lab2
*--------------------------------------------------------------------
* Author’s name and email: Tessa Williams williamstm5@etsu.edu
* Course-Section: CSCI-2910
* Creation Date: 05/25/2023
* -------------------------------------------------------------------
*/
using ConsoleTables;
namespace csci2910_lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menuOpt;
            //Display welcome message in center of window
            string welcome = "Welcome to Lab 2";
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcome);

            do
            {
                DisplayMenu();
                menuOpt = GetMenuOpt(4);
                Console.Clear();
                switch (menuOpt)
                {
                    
                    case 1:
                        //Section header with title displayed
                        string title = "Add Two Numbers";
                        Divider();
                        Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                        Console.WriteLine(title);
                        Divider();

                        //Get two integers from user and add them together. Then display the sum.
                        int sum;
                        sum = SumOfArray(GetTwoIntegers());
                        Console.WriteLine($"Sum = {sum}");
                        break;
                    case 2:
                        //Section header with title displayed
                        title = "Add Two Numbers";
                        Divider();
                        Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                        Console.WriteLine(title);
                        Divider();

                        //Get an integer from the user and display the multiplication table based on how high the user wishes to multiply by.
                        int num;
                        int highestNum;
                        bool success;
                        Console.Write("Enter the integer you'd like to see a multiplication table for: ");
                        success = Int32.TryParse(Console.ReadLine(), out num);
                        while (!success)
                        {
                            Console.Write("*Invalid Input* Please enter an integer: ");
                            success = Int32.TryParse(Console.ReadLine(), out num);
                        }
                        Console.Write("Enter the highest integer you wish to multiply by: ");
                        success = Int32.TryParse(Console.ReadLine(), out highestNum);
                        while (!success)
                        {
                            Console.Write("*Invalid Input* Please enter an integer: ");
                            success = Int32.TryParse(Console.ReadLine(), out highestNum);
                        }
                        DisplayMultiplicationTable(num, highestNum);
                        break;
                    case 3:
                        //Section header with title displayed
                        title = "Bytes in Memory Table";
                        Divider();
                        Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                        Console.WriteLine(title);
                        Divider();

                        //using ConsoleTables generate a new table and add rows of information. Then display that table.
                        var table = new ConsoleTable("Type","Byte(s) of memory","Min","Max");
                        table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
                        table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
                        table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
                        table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
                        table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
                        table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
                        table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
                        table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
                        table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);
                        table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);
                        table.AddRow("sbyte", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
                        table.Write(Format.Alternative);
                        break;
                    case 4:
                        double num1;
                        double num2;
                        char operand;
                        double answer;
                        string cont = "";
                        //Section header with title displayed
                        title = "Calculator";
                        Divider();
                        Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                        Console.WriteLine(title);
                        Divider();
                        do
                        {
                            //Get and validate first number for equation
                            Console.Write("First Number: ");
                            success = Double.TryParse(Console.ReadLine(), out num1);
                            while (!success)
                            {
                                Console.Write("*Invalid Input* Please enter a number: ");
                                success = Double.TryParse(Console.ReadLine(), out num1);
                            }
                            //Get and validate operand for equation
                            Console.Write("Select an Operand (+,-,*,/,%): ");
                            operand = Console.ReadLine()[0];
                            while (operand != '+' && operand != '-' && operand != '*' && operand != '/' && operand != '%')
                            {
                                Console.Write("*Invalid Input* Select an Operand (+,-,*,/,%): ");
                                operand = Console.ReadLine()[0];
                            }
                            //Get and validate second number for equation
                            Console.Write("Second Number: ");
                            success = Double.TryParse(Console.ReadLine(), out num2);
                            while (!success)
                            {
                                Console.Write("*Invalid Input* Please enter a number: ");
                                success = Double.TryParse(Console.ReadLine(), out num2);
                            }

                            if (operand == '+')
                            {
                                Console.WriteLine(Add(num1, num2));
                            }
                            else if (operand == '-')
                            {
                                Console.WriteLine(Subtract(num1, num2));
                            }
                            else if (operand == '*')
                            {
                                Console.WriteLine(Multiply(num1, num2));
                            }
                            else if (operand == '/')
                            {
                                Console.WriteLine(Divide(num1, num2));
                            }
                            else if (operand == '%')
                            {
                                Console.WriteLine(Mod(num1, num2));
                            }
                            else
                            {
                                Console.WriteLine("An Error occured...");
                            }
                            Console.WriteLine("Type 'esc' to go back to the main menu, or enter key to continue...");
                            cont = Console.ReadLine();
                        } while (cont != "esc");
                        break;
                    case 0:

                        break;
                    default:

                        break;
                }

            } while (menuOpt != 0);

        }
        /// <summary>
        /// creates a divider that is the length of the window
        /// </summary>
        public static void Divider()
        {
            
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }
        /// <summary>
        /// Displays a formated menu
        /// </summary>
        public static void DisplayMenu()
        {
            string title = "Menu";
            //Centers menu title in center of console window
            Divider();
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Divider();
            Console.WriteLine("1. Add Two Numbers");
            Console.WriteLine("2. Multiplication Table");
            Console.WriteLine("3. Num of bytes in Memory");
            Console.WriteLine("4. Calculator");
        }
        /// <summary>
        /// Gets the menu option from the user and ensures it is viable or else it throws an exception and asks them for a new input
        /// </summary>
        /// <param name="maxOpt">The max number of menu choices</param>
        /// <returns>an integer representing the menu choice</returns>
        public static int GetMenuOpt(int maxOpt)
        {
            int menuopt = 0;
            bool success = false;

            while (!success)
            {
                try
                {
                    Console.Write("Menu Selection: ");
                    menuopt = int.Parse(Console.ReadLine());
                    if (menuopt > maxOpt || menuopt < 0)
                    {
                        throw new MenuOptException();
                    }

                    success = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n*Invalid Input. Please enter an integer.*\n");
                }
                catch (MenuOptException ex)
                {
                    Console.WriteLine($"\n*Invalid Input. Please enter a number 0-{maxOpt}.*\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n*An unknown error occured. Please try again." + ex.Message + "*\n");
                }
            }

            return menuopt;
        }
        /// <summary>
        /// Finds the sum of an array of integers
        /// </summary>
        /// <param name="num1">first integer to add</param>
        /// <param name="num2">second integer to add</param>
        /// <returns>int sum of the two numbers</returns>
        public static int SumOfArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        /// <summary>
        /// Asks for user to input two numbers, and validates that the inputs are integers. 
        /// If not, the user is asked for inputs again until a valid input is received.
        /// </summary>
        /// <returns>array containing the two integers from the user</returns>
        public static int[] GetTwoIntegers()
        {
            bool success;
            int num1;
            int num2;
            int[] nums = new int[2];
            Console.WriteLine("Please enter numbers to add...");
            Console.Write("First number: ");
            success = Int32.TryParse(Console.ReadLine(), out num1);
            while (!success)
            {
                Console.WriteLine("*Invalid Input* Please enter an integer...");
                Console.Write("First number: ");
                success = Int32.TryParse(Console.ReadLine(), out num1);
            }
            Console.Write("Second number: ");
            success = Int32.TryParse(Console.ReadLine(), out num2);
            while (!success)
            {
                Console.WriteLine("*Invalid Input* Please enter an integer...");
                Console.Write("Second number: ");
                success = Int32.TryParse(Console.ReadLine(), out num2);
            }
            nums[0] = num1;
            nums[1] = num2;

            return nums;
        }
        /// <summary>
        /// displays a multiplication table for a base integer up to a specified limit
        /// </summary>
        /// <param name="baseNum">the base integer for the multiplication table</param>
        /// <param name="highestNum">the highest integer to multiply by</param>
        public static void DisplayMultiplicationTable(int baseNum, int highestNum)
        {
            for (int i = 0; i <= highestNum; i++)
            {
                Console.WriteLine($"{baseNum}*{i} = {baseNum*i}");
            }
        }
        /// <summary>
        /// finds the sum of two numbers
        /// </summary>
        /// <param name="num1">first number to add</param>
        /// <param name="num2">second number to add</param>
        /// <returns>sum of both numbers</returns>
        public static double Add(double num1, double num2)
        {
            double sum;
            sum = num1 + num2;
            return sum;
        }
        /// <summary>
        /// finds the difference of two numbers
        /// </summary>
        /// <param name="num1">first number to subtract from</param>
        /// <param name="num2">number to subtract from the first</param>
        /// <returns>the difference between the two numbers</returns>
        public static double Subtract(double num1, double num2)
        {
            double diff;
            diff = num1 - num2;
            return diff;
        }
        /// <summary>
        /// finds the product of two numbers
        /// </summary>
        /// <param name="num1">first number to multiply</param>
        /// <param name="num2">second number to multiply</param>
        /// <returns>product of two numbers</returns>
        public static double Multiply(double num1, double num2)
        {
            double product;
            product = num1 * num2;
            return product;
        }
        /// <summary>
        /// finds the quotient of two numbers
        /// </summary>
        /// <param name="num1">the dividend</param>
        /// <param name="num2">the divisor</param>
        /// <returns>the quotient of the two numbers</returns>
        public static double Divide(double num1, double num2)
        {
            double quotient;
            quotient = num1 / num2;
            return quotient;
        }
        /// <summary>
        /// finds the remainder left of two divided numbers
        /// </summary>
        /// <param name="num1">dividen</param>
        /// <param name="num2">divisor</param>
        /// <returns>the remainder from the division</returns>
        public static double Mod(double num1, double num2)
        {
            double modulous;
            modulous = num1 % num2;
            return modulous;
        }
    }
}