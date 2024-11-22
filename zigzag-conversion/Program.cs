//https://leetcode.com/problems/zigzag-conversion/

Console.WriteLine(Convert("AB", 1));

string Convert(string s, int numRows)
{
    var length = s.Length;

    if (string.IsNullOrEmpty(s)) return "";
    if (string.IsNullOrEmpty(s) || numRows == 0 ) return "";
    var result = "";
    string[] sa = new string[numRows];
    bool backwards = false;
    int count = 0;
    for (int i = 0; i < length; i++)
    {        
        sa[count] += s[i];

        if (count == numRows - 1)
        {
            backwards = true;
        }
        if (count == 0)
        {
            backwards = false;
        }

        count = backwards ? count - 1 : count + 1;

    }
    for (int i = 0; i < sa.Length; i++)
    {
        if (sa[i] == null)
            break;
        
        result += sa[i].ToString();
        
    }

    return result;
}