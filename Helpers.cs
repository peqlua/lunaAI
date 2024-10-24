class H
{
    public static void Write(string text)
    {
        Console.WriteLine(":::> " + text);
    }

    public static void Write(int number)
    {
        Write(number.ToString());
    }

    public static string Read()
    {
        return Console.ReadLine();
    }

    public static int ReadInt()
    {
        return int.Parse(Console.ReadLine());
    }

    public static double ReadDouble()
    {
        return double.Parse(Console.ReadLine());
    }

    public static int Random(int first, int end)
    {
        var random = new Random();
        return random.Next(first, end + 1);
    }

}
