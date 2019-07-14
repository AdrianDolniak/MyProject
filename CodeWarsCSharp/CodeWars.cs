using System;

namespace MyProject.CodeWarsCSharp
{
    public static class Watermelon
    {
        public static bool Divide(int weight)
        {
            if (weight != 2)
            {
                return weight%2 == 0;
            }
            return false;
        }
    }
    
    public static class ReversedString
    {
        public static string Reversed(string str) 
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);      
        }
    }
    
    public static class EvenOdd
    {
        public static string EvenOrOdd(int number)
        {
            return number%2 == 0 ? "Even" : "Odd";
        }
    }
    
    public static class DivisibleNb
    {
        public static bool IsDivisible(long n, long x, long y)
        {
            return n%x == 0 && n%y == 0;
        }
    }
    
    public static class Descending
    {
      public static int DescendingOrder(int num)
       { 
        var count = new int[10]; 
    
        var str = num.ToString(); 
    
        foreach (var t in str)
            count[t - '0']++;

        int result = 0, multiplier = 1; 
          
        for (var i = 0; i <= 9; i++) 
        { 
            while (count[i] > 0) 
            { 
                result = result + (i * multiplier); 
                count[i]--; 
                multiplier = multiplier * 10;
            } 
        } 
        return result; 
      } 
    }
    
    public static class RemoveFirstChar
    {
        public static string Remove_char(string s)
        {
           var a = s.Remove(s.Length - 1);
           return a.Substring(1);
         }
    }
    
    public static class Binary
    {
        public static string AddBinary(int a, int b)
        {
            var binary = Convert.ToString(a+b, 2);
            return binary;
        }
    }
    
    public static class OppositeNumber
    {
        public static int Opposite(int number)
        {
            if (number < 0)
            {
                return (Math.Abs(number));
            }
            return (Math.Abs(number) * -1);
        }
    }
}