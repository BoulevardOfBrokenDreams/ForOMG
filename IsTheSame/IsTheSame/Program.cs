class Solution
{
    public static bool IsTheSameChar(List<List<char>> Mass, int Count)
    {
        for(int i = 0; i < Count - 1; i++)
        {
            if(Mass[i].Count() != Mass[i + 1].Count())
            {
                return false;
            }
        }
        for(int i = 0; i < Mass[0].Count(); i++)
        {
            for (int j = 0; j < Count - 1; j++)
            {
                if (Mass[j][i] != Mass[j + 1][i])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static void Main()
    {
        int Count = Convert.ToInt32(Console.ReadLine());
        List<List<char>> Mass = new List<List<char>>();

        for(int i = 0; i < Count; i++)
        {
            string s = Console.ReadLine();
            Mass.Add(s.ToList<char>());
            Mass[i].Sort();
        }

        Console.WriteLine(IsTheSameChar(Mass, Count));
    }
}