using System.Text;

namespace project_test_console.lesson2;

public class Homework2
{
    public static void Run()
    {
        Console.Write("введите безобразную строку, напрмиер aaabbbdddccd233:");
        var input = Console.ReadLine()!;
        var sb = new StringBuilder();
        int count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i + 1 < input.Length && input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                sb.Append(input[i]);
                sb.Append(count);
                count = 1;
            }
        }

        Console.WriteLine(sb.ToString());
    }
}