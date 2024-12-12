namespace TechTest;

public class Test
{
    public static bool SimpleMethod(string input)
    {
        // "{}{}{}"
        var listChar = new Stack<char>();
        if (string.IsNullOrEmpty(input) || input.StartsWith('}'))
        {
            return false;
        }

        foreach (char c in input)
        {
            if (c is '{')
            {
                listChar.Push(c);
            }
            else if (c is '}')
            {
                if (listChar.Count is 0 || listChar.Pop() is not '{')
                {
                    return false;
                }
            }
        }

        return listChar.Count is 0;
    }
}
