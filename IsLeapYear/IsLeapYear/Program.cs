class solution
{
    public static bool IsLeap(int Year)
    {
        if(Year % 4 == 0 || Year % 100 != 0 && Year % 400 == 0)
        {
            return true;
        }
        return false;
    }
    public static void Main()
    {
        int Year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsLeap(Year));
    }
}
