using Microsoft.VisualBasic.CompilerServices;

namespace AlgorithmLib;

public static class StringMatcher
{
    private static List<Dictionary<char, int>> BuildTable(string pattern, List<char> inputs)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        List<Dictionary<char, int>> table = new List<Dictionary<char, int>>();
        for (var k = 0; k < pattern.Length + 1; k++)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var letter in inputs)
            {
                var pka = pattern.Substring(0, k) + letter;
                var i = Math.Min(k + 1, pattern.Length);

                while (!pka.EndsWith(pattern.Substring(0, i)))
                {
                    i -= 1; 
                }

                map[letter] = i; 
            }
            table.Add(map);
        }
        return table;
    }
    
    public static List<int> Match(string text,  string pattern, List<char> inputs)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var table = BuildTable(pattern, inputs);

        var matchState = table.Count - 1;
        int state = 0;
        List<int> results = new List<int>();
        for (var i = 0; i < text.Length; i++)
        {
            state = table[state][text[i]];
            if (state == matchState)
            {
                results.Add(i);
            }
        }
        return results;
    }
    
}