namespace project_test_console;

public class Homework1 {
    public static void Run() {
        while (true) {
            Console.WriteLine("enter your temperature:");
            string str = Console.ReadLine();

            if (double.TryParse(str, out double result)) {
                result = (result * 1.8) + 32;
                Console.WriteLine($"temperature Fahrenheit: {result} F");
                break;
            } else {
                Console.WriteLine("invalid input. pls enter a number");
            }
        }
    }
}