namespace project_test_console;

public class Homework5 {
    public static void Run() {
        int selected = 0;
        double balance = 456;
        while (true) {
            Console.Clear();
            string[] menu = {
                "check balance",
                "deposit",
                "withdraw",
                "exit"
            };
            for (int i = 0; i < menu.Length; i++) {
                string value = i == selected ? "> " + menu[i] : "  " + menu[i];
                Console.WriteLine(value); 
            }
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.UpArrow && selected > 0) {
                selected--;
            } else if (key == ConsoleKey.DownArrow && selected < menu.Length - 1) {
                selected++;
            }

            if (key == ConsoleKey.Enter) {
                switch (selected) {
                    case 0:
                        Console.WriteLine($"your balance: $ {balance}");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("enter amount to deposit");
                        string amount1 = Console.ReadLine();
                        if (double.TryParse(amount1, out double result1)) {
                            if (result1 >= 0) {
                                balance += result1;
                                Console.WriteLine($"deposited: $ {result1}");
                                Console.WriteLine($"your balance: $ {balance}");
                            }
                            else {
                                Console.WriteLine("amount cannot be negative");
                            }
                        }
                        else {
                            Console.WriteLine("invalid amount");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("enter amount to withdraw:");
                        string amount2 = Console.ReadLine();
                        if (double.TryParse(amount2, out double result2)) {
                            if (result2 < 0) {
                                Console.WriteLine("amount cannot be negative");
                            } else if (result2 > balance) {
                                Console.WriteLine("not enough money");
                            }
                            else {
                                balance -= result2;
                                Console.WriteLine($"withdrawn: $ {result2}");
                                Console.WriteLine($"your balance: $ {balance}");
                            }
                        }
                        else {
                            Console.WriteLine("invalid amount");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}