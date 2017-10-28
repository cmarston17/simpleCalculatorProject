
namespace FirstCsharpConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the calculator!");
            bool goon = true;
            while (goon)
            {
                Console.WriteLine("please enter a number to do a math problem!");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Invalid entry, please enter a number..");
                Console.WriteLine("Enter a second number please");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Invalid entry, Please enter a real number idiot..");
                Console.WriteLine("Now choose what math problem you want to do!");
                Console.WriteLine("1 Addition");
                Console.WriteLine("2 Subtraction");
                Console.WriteLine("3 Division");
                Console.WriteLine("4 Multiply");
                Char option = Console.ReadKey().KeyChar;
                Console.WriteLine();
                double result = 0;
                bool validOption = true;
                switch (option)
                {
                    case '1':
                        result = a + b;
                        break;
                    case '2':
                        result = a - b;
                        break;
                    case '3':
                        result = a / b;
                        break;
                    case '4':
                        result = a * b;
                        break;
                    default:
                        validOption = false;
                        break;
                }
                if (validOption)
                    Console.WriteLine("result {0}", result);
                else
                    Console.WriteLine("Invalid Option jesus your dumb..");
                Console.WriteLine(" Would you like to do another problem? y/n?");
                validOption = false;
                while (!validOption)
                {

                    switch (Console.ReadKey().KeyChar.ToString().ToLower())
                    {
                        case "y":
                            goon = true;
                            validOption = true;
                            break;
                        case "n":
                            goon = false;
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option, enter y/n");
                            break;

                    }
                }
                Console.WriteLine();

            }

        }
    }
}
