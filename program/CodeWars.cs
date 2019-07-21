using System;
using System.Linq;

namespace ProjectCSharp.program
{
    public static class Watermelon
    {
        public static bool Divide(int weight)
        {
            if (weight != 2)
            {
                return weight % 2 == 0;
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
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }

    public static class DivisibleNb
    {
        public static bool IsDivisible(long n, long x, long y)
        {
            return n % x == 0 && n % y == 0;
        }
    }

    public static class Descending
    {
        public static int DescendingOrder(int num)
        {
            var numbers = num.ToString().ToList();
            numbers.Sort();
            numbers.Reverse();
            var sorted = int.Parse(string.Join("", numbers));
            return sorted;
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
            var binary = Convert.ToString(a + b, 2);
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

    public static class SumOfTwoLowestPositiveIntegers
    {
        public static long Sum(string x)
        {
            var numbers = x.Split(',').Select(Int64.Parse).ToList();
            numbers.Sort();
            var numF = numbers[0];
            var numS = numbers[1];
            var numSum = numF + numS;
            return numSum;
        }
    }

    public static class ConvertAStringToAnArray
    {
        public static string[] ConvertToString(string x)
        {
            string[] words = x.Split(default(string[]), StringSplitOptions.None);
            return words;
        }
    }
}

            
        
    
