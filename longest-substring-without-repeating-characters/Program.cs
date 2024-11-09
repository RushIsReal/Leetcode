

LengthOfLongestSubstring("dvdf");

static void LengthOfLongestSubstring(string s)
{
    string looped = "";
    int result = 0;
    for (var i = 0; s.Length > i; i++)
    {
        for (var j = i; s.Length > j; j++)
        {
            if (looped.Contains(s[j]))
            {
                result = (result < looped.Length) ? looped.Length : result;
                looped = "";
                break;
            }
            looped += s[j];
        }
    }
    result = (result < looped.Length) ? looped.Length : result;
    Console.WriteLine(result);
}