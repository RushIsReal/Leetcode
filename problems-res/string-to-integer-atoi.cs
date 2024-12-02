namespace Problems
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            int result = 0;
            int sign = 1;
            bool start = false;            
            bool isStarterChar = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] == ' '))
                {
                    start = true;
                }
                if (!start) continue;
                if (isStarterChar)
                {
                    isStarterChar = false;
                    if (s[i] == '-' || s[i] == '+')
                    {
                        if (s[i] == '-')
                        {
                            sign = -1;
                        }
                        continue;
                    }
                }
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int digit = s[i] - '0';                    
                    if (result > (int.MaxValue - digit) / 10) 
                    {
                        return sign == 1 ? int.MaxValue : int.MinValue; 
                    }
                    result = result * 10 + digit;
                }
                else
                {
                    return result * sign;
                }
            }
            return result * sign;
        }
    }
}