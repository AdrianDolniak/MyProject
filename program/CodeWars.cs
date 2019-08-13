using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

    public static class RemoveFirstAndLastChar
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

    public static class SumWithoutHighestAndLowestNumber
    {
        public static int Sum(int[] x)
        {
            if (x == null)
                return 0;
            if (x.Length <= 1)
                return 0;
            var numMax = x.Max();
            var numMin = x.Min();
            var sumAll = x.Sum();
            var sum = sumAll - (numMax + numMin);
            return sum;
        }
    }

    public static class ShortestWord
    {
        public static int Short(string x)
        {
            var wordsSplit = x.Split(default(string[]), StringSplitOptions.None);
            var wordsSort = from element in wordsSplit orderby element.Length select element;
            var shortest = wordsSort.First();
            return shortest.Length;
        }
    }

    public static class IsIsogram // solution not ready yet :)
    {
        public static bool Isogram(string x)
        {
            var lower = x.ToLower();
            var chars = lower.ToArray();
            var charsDist = lower.ToCharArray().Distinct().ToArray();
            var strDist = new string(charsDist);
            var str = new string(chars);
            {
                return strDist == str || x == "";
            }
        }
    }
}
            
        
    
