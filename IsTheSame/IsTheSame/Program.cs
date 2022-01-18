class Solution
{
    public static bool IsTheSameChar(List<string> Strings)
    {
        var Count = Strings.Count();
        List<List<char>> MassChar = new List<List<char>>();

        for(int i = 0; i < Count; i++)
        {
            MassChar.Add(Strings[i].ToList<char>());
            MassChar[i].Sort();
        }

        for(int i = 0; i < Count - 1; i++)
        {   
            if(MassChar[i].Count() != MassChar[i + 1].Count())
            {
                return false;
            }
        }

        for(int i = 0; i < MassChar[0].Count(); i++)
        {
            for (int j = 0; j < Count - 1; j++)
            {
                if (MassChar[j][i] != MassChar[j + 1][i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}