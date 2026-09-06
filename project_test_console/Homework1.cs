namespace project_test_console;
/* Напишите программу, которая запрашивает у пользователя температуру
 * в градусах Цельсия и выводит температуру в Фаренгейтах.
 * Программа должна корректно работать с дробными значениями.
 */
public class Homework1
{
    public static void Run()
    {
        const int tempKelvin = 273;
        while (true)
        {
            Console.WriteLine("enter your temperature:");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int result))
            {
                result += tempKelvin;
                Console.WriteLine($"temperature Kelvin: {result} K");
                break;
            }
            else
            {
                Console.WriteLine("invalid input. pls enter a number");
            }
        }
    }
}