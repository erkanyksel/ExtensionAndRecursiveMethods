internal class Program
{
    private static void Main(string[] args)
    {
        // Rekursive 
        // 3^4
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);

        Tasks instance = new Tasks();
        Console.WriteLine(instance.Expo(3, 4));

        // Extension Methods

        string ifade = "Erkan Yuksel";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        Console.WriteLine(ifade.CheckSpaces());

        if (sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] array = { 9, 3, 6, 2, 1, 5, 0 };

        array.SortArray();
        array.WriteOnScreen();

        int number = 5;
        number.IsEvenNumber();
        Console.WriteLine(number.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharachter());


    }
}

public class Tasks
{
    public int Expo(int num1, int num2)
    {
        if (num2 < 2)
            return num1;

        return Expo(num1, num2 - 1) * num1;
    }

    // Expo(3,4)
    // Expo(3,3)*3;
    // Expo(3,2)*3*3;
    // Expo(3,1)*3*3*3;
    // 3*3*3*3=3^4;


}

public static class Extensions
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] array = param.Split(" ");
        return string.Join("", array);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void WriteOnScreen(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstCharachter(this string param)
    {
        return param.Substring(0, 1);
    }

}