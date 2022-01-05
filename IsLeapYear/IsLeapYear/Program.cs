class solution
{
    public static bool IsLeap(int Year)
    {
        return Year % 4 == 0 || Year % 100 != 0 && Year % 400 == 0;
    }
    public static void Main()
    {
        int Year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsLeap(Year));
    }
}
