class Solution
{
    public static void Main()
    {
        string Str = Console.ReadLine();

        Console.WriteLine(IsBalanced(Str));
    }
    public static bool IsBalanced(string Str)
    {
        Stack<char> Brackets = new Stack<char>();

        for (int i = 0; i < Str.Length; i++)
        {
            if (Str[i] == '(' || 
                Str[i] == '[' || 
                Str[i] == '{')
            {
                Brackets.Push(Str[i]);
            }
            else
            {
                if (Brackets.Count() < 1 ||
                   (Brackets.Peek() == '(' && Str[i] != ')') ||
                   (Brackets.Peek() == '[' && Str[i] != ']') ||
                   (Brackets.Peek() == '{' && Str[i] != '}'))
                {
                    return false;
                }
                Brackets.Pop();
            }
        }

        return Brackets.Count() == 0;
    }
}