namespace project_test_console;

public class Homework2 {
    public static void Run() {
        while (true) {
            Console.WriteLine("enter first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("enter second number");
            string number2 = Console.ReadLine();

            if (int.TryParse(number1, out int result1) && int.TryParse(number2, out int result2)) {
                string msg = result1 > result2 ? "first is bigger"
                    : result1 < result2 ? "second is bigger"
                    : "numbers are equal";
                Console.WriteLine(msg);
                break;
            } else {
                Console.WriteLine("invalid input. pls enter again");
            }
        }
    }
}