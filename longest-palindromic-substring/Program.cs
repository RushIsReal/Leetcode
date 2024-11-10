Console.WriteLine(LongestPalindrome("saras"));
Console.WriteLine(LongestPalindrome("bbaa"));
Console.WriteLine(LongestPalindrome("abba"));
Console.WriteLine(LongestPalindrome("ccc"));
Console.WriteLine(LongestPalindrome("aaaaa"));
Console.WriteLine(LongestPalindrome("bb"));

string LongestPalindrome(string s)
{
    if (string.IsNullOrEmpty(s) || s.Length < 1)
        return "";

    int start = 0, end = 0;

    for (int i = 0; i < s.Length; i++)
    {
        int len1 = ExpandAroundCenter(s, i, i);    
        int len2 = ExpandAroundCenter(s, i, i + 1);
        int len = Math.Max(len1, len2);

        if (len > end - start)
        {
            start = i - (len - 1) / 2;
            end = i + len / 2;
        }
    }

    return s.Substring(start, end - start + 1);
}

int ExpandAroundCenter(string s, int left, int right)
{
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        left--;
        right++;
    }
    return right - left - 1;
}

// //Refactor this problem, first try

// var value = "ccc";
// //var value = "saras";
// var result = "";
// var partialresult = "";
// var length = value.Length;

// result = length > 0 ? value[0].ToString() : "";
// for (int i = 0; i < length; i++)
// {
//     var nextPos = i + 1;
//     var nextNextPos = i + 2;
//     if (i >= length - 1 || nextPos >= length)
//         break;

//     var left = value[i];
//     var right = value[nextPos];
//     var plusCounter = 1;
//     Console.WriteLine(right);
//     if (left == right)
//     {
//         while (left == right)
//         {
//             partialresult = $"{left}{partialresult}{right}";
//             Console.WriteLine(partialresult);
//             if (i == 0 || nextPos == length - 1 || i - plusCounter < 0 || nextPos + plusCounter > length - 1) break;
//             left = value[i - plusCounter];
//             right = value[nextPos + plusCounter];
//             plusCounter++;
//         }
//         Console.WriteLine(partialresult);
//         if (partialresult.Length > result.Length)
//         {
//             result = partialresult;
//         }
//         partialresult = "";
//     }

//     partialresult = "";
//     if (nextNextPos > length - 1)
//         break;
//     var twoToTheRight = value[nextNextPos];
//     partialresult = right.ToString();
//     while (left == twoToTheRight)
//     {
//         partialresult = $"{left}{partialresult}{twoToTheRight}";
//         if (i == 0 || nextNextPos == length - 1 || i - plusCounter < 0 || nextNextPos + plusCounter > length - 1) break;
//         left = value[i - plusCounter];
//         twoToTheRight = value[nextNextPos + plusCounter];
//         plusCounter++;
//     }
//     Console.WriteLine(partialresult);
//     if (partialresult.Length > result.Length)
//     {
//         result = partialresult;
//     }
//     partialresult = "";

// }

// Console.WriteLine(result);
