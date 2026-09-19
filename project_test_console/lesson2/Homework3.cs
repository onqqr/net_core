namespace project_test_console.lesson2;

public class Homework3
{
    public static bool IsPalindrome(string value)
    {
        string format = value.Replace(" ", "");
        int left = 0;
        int right = format.Length - 1;

        while (left < right)
        {
            string leftChar = format[left].ToString();
            string rightChar = format[right].ToString();

            if (!string.Equals(
                    leftChar,
                    rightChar,
                    StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            
            left++;
            right--;
        }
        return true;
    }

    public static void Run()
    {
        Console.WriteLine("введите строку палиндром: ");
        string input = Console.ReadLine()!;

        Console.WriteLine(IsPalindrome(input));
    }
}