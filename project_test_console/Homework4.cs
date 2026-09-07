namespace project_test_console;

public class Homework4
{
    public static void Run() {
        int secretNumber = 19;
        int att = 0;
        
        Console.WriteLine("enter a number (0 - 20)");

        while (true) {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result)) {
                att++;
                if (result > secretNumber) {
                    Console.WriteLine("secret number is lower");
                } else if (result < secretNumber) {
                    Console.WriteLine("secret number is higher");
                } else {
                    Console.WriteLine($"Success! secret number - {secretNumber}. \nnumber of attempts: {att} ");
                    break;
                }
            }
            else
            {
                Console.WriteLine("invalid input, try again");
            }
        }
    }
}