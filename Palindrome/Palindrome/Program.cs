class Solution
{
    private static readonly char[] _chars = new char[]
    {
        '"',
        '\'',
        '.',
        ',',
        '<',
        '>',
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        ';',
        ':',
        '^',
        '?',
        '!',
        '+',
        '=',
        '-',
        '_',
        '*',
        '&',
        '|',
        '\\',
        '/',
        ' '
    };
    public static bool IsPalindrome(string String)
    {
        String = String.ToLower();

        var FirstIndex = 0;
        var LastIndex = String.Length - 1;

        while (FirstIndex < LastIndex)
        {
            while (_chars.Contains(String[FirstIndex]))
            {
                FirstIndex++;
                continue;
            }

            while (_chars.Contains(String[LastIndex]))
            {
                LastIndex--;
                continue;
            }

            if (String[FirstIndex] != String[LastIndex])
            {
                return false;
            }

            FirstIndex++;
            LastIndex--;
        }
        return true;
    }
}
/*                                                          +
 * ...asdf,,,,!!!![][][][()()()(_++_=-+_fdsa!!!             +
 * as                                                       +
 * asa                                                      +
 * !.,.,.,.,.,,.fff.,.,.,.,g';';';fff\":\"::                +
 * !.,   .,.,.,.,,.fff.,.    ,.,.,g   ';';';fff\":\"::      +
 */