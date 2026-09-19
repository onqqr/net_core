namespace project_test_console.lesson2;

public class Homework1
{
    public static void Run()
    {
        Console.Write("введите числа через запятую:");
        var input = Console.ReadLine()!;
        string[] parts  = input.Split(",");
        int[] arr = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            arr[i] = int.Parse(parts[i].Trim());
        }

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

        Console.WriteLine(string.Join(", ", arr));
    }
}