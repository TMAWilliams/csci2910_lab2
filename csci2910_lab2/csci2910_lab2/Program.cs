namespace csci2910_lab2
{
    public class Program
    {
        static void Main()
        {
            //Display welcome message in center of window
            string welcome = "Welcome to Lab 2";
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcome);

            DisplayMenu();

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
    }
}