namespace Problems
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int aux = x;
            Int64 reversed = 0;
            while (aux != 0)
            {
                int resto = aux % 10;
                aux /= 10;
                reversed = reversed * 10 + resto;
            }
            return (reversed > Int32.MaxValue || reversed < Int32.MinValue) ? 0 : (int)reversed;
        }

        //Best Resolution        
        // public int Reverse(int x)
        // {
        //     int result = 0;
        //     while (x != 0)
        //     {
        //         var remainder = x % 10;
        //         var temp = result * 10 + remainder;
        //         if ((temp - remainder) / 10 != result)
        //         {
        //             return 0;
        //         }
        //         result = temp;
        //         x /= 10;
        //     }

        //     return result;
        // }
    }
}