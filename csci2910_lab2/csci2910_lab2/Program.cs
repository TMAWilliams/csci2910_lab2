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
namespace csci2910_lab2
{
    public class Program
    {
        static void Main()
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
                        int sum;
                        string title = "Add Two Numbers";

                        Divider();
                        Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                        Console.WriteLine(title);
                        Divider();

                        sum = Sum(GetTwoIntegers());
                        Console.WriteLine($"Sum = {sum}");
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

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
        public static int Sum(int[] nums)
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
    }
}