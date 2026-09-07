namespace project_test_console;

public class Homework3 {
    public static void Run() {
        while (true) {
            Console.WriteLine("enter a number");
            string number = Console.ReadLine();
            
            if (int.TryParse(number, out int result)) {
                if (result == 0) {
                    Console.WriteLine("your a number - 0");
                    return;
                }
                
                string sign = (result > 0) ? "positive" : "negative";
                string parity = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"Number is {sign} \nNumber is {parity}");
                break;
            } else {
                Console.WriteLine("invalid input. pls enter a number");
            }
        }
    }
}