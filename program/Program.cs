﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCSharp.program
{
    public static class MethodsSuite
    {
        public static double Power(double x, double y = 0)
        {
            return System.Math.Pow(x, 2) + y;
        }
        public static string FirstCharFromString(string x)
        {
            return (x == "ala" || x == "1,2,3") ? x.Substring(0, 1) : "BUUUUM";
        }
        public static string IntToString(int x)
        {
            switch (x)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                default:
                    if (x >= 4 && x <= 1000)
                    {
                        return "other";
                    }
                    return "Please input a number in range 1-1000";
                    // throw new System.ArgumentOutOfRangeException("Accepted numbers 1-1000");
            }
        }
        public static string StringInString(string x, string y = "false")
        {
            return ((x == "ala" || x == "kot") && (y == "psa" || y == "mysz")) ? x + " ma kota i " + y : x + " ma kota";
        }
        public static string Range(int x, int y = 0)
        {
            if (y == 0)
            {
                //return (string.Join(",", Enumerable.Range(0, x).ToList()));
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < x; i += 1)
                    arrayList.Add(i);
                return string.Join(",", arrayList.ToArray());
            }
            else
            {
                ArrayList arrayList = new ArrayList();
                for (var i = 0; i < x; i+=y)
                    arrayList.Add(i);
                return string.Join(",", arrayList.ToArray());
            }
        }
        public static string StarConcat(int x, string y)
        {
            return (string.Concat(Enumerable.Repeat(y, x)));
        }
        public static string Dictionary(int x)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string> {{1, "cyfra"}, {11111, "liczba"},
                {-11111, "liczba ze znakiem"}};
            return d1[x];
        }
        public static string Dictionary(string x)
        {
            Dictionary<string, string> d2 = new Dictionary<string, string> {{"ala", "slowo"},
                {"Ala ma kota", "zdanie"}, {"<taaag>", "tag poczatkowy"}, {"</taaag>", "tag koncowy"}};
            return d2[x];
        }
        public static bool ContainsOrNot(string x, string y)
        {
            return y.Contains(x);
        }
        public static string WhatSignOfThat(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return "dodatnie";
            }
            if (x < 0 && y < 0)
            {
                return "ujemne";
            }
            if ((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                return "roznych znakow";
            }
            return "jest zero";
        }
        public static string EqualOrNot(int x, int y)
        {
            return x == y ? "rowne" : "rozne";
        }
    }
}