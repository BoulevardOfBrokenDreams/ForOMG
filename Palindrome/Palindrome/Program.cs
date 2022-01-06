class Solution
{
    public static bool IsPalindrome(string Str)
    {
        int LenStr = Str.Length - 1;

        for(int i = 0; i < LenStr / 2; i++)
        {
            if(Str[i] != Str[LenStr - i])
            {
                return false;
            }
        }
        return true;
    }
    public static void Main()
    {
        string Str = Console.ReadLine();
        for(int i = 0; i < Str.Length; i++)
        {
            if (char.IsPunctuation(Str[i]) || Str[i] == ' ')
            {
                Str = Str.Remove(i,1);
            }
        }
        Console.WriteLine(IsPalindrome(Str.ToLower()));
    }
}