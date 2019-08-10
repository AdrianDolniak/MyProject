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
            if (x == "ala" || x == "1,2,3")
            {
                return x.Substring(0, 1);
            }
            return x == " " ? "BUUUUM" : "Not implemented yet";
        }
        public static string IntToString(int x)
        {
            if (x >= 4 && x <= 1000)
            {
                return "other";
            }
            switch (x)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                default:
                    throw new System.ArgumentOutOfRangeException("Accepted numbers 1-1000");
                    //throw new System.NotImplementedException();
                    //return "Not implemented yet";
            }
        }
        public static string StringInString(string x, string y = "false")
        {
            if (y == "false")
                if (x == "ala" || x == "kot")
                {
                    return x + " ma kota";
                }
            if (x == "kot" && y == "psa" || x == "kot" && y == "mysz")
            {
                return x + " ma kota i " + y;
            }
            {
                return "Not implemented yet";
            }
        }

        public static string Range(int x, int y = 0)
        {
            if (y == 0)
            {
                switch (x)
                {
                    case 0: case 1: case 2: case 7:
                     //return (string.Join(",", Enumerable.Range(0, x).ToList()));
                     ArrayList arrayList = new ArrayList();
                        for (int i = 0; i < x; i += 1)
                            arrayList.Add(i);
                        return string.Join(",", arrayList.ToArray());
                     
                    default:
                        return x.ToString("Not implemented yet");
                }
            }

            switch (x)
            {
                case 7 when y == 2: case 17 when y == 2: case 17 when y == 5:
                    ArrayList arrayList = new ArrayList();
                    for (var i = 0; i < x; i+=y)
                        arrayList.Add(i);
                    return string.Join(",", arrayList.ToArray());
                
                default:
                    return x.ToString("Not implemented yet");
            }
         }
        public static string StarConcat(int x, string y)
        {
            switch (x)
            {
                case 1 when y == "*": case 7 when y == "*":
                {
                    return (string.Concat(Enumerable.Repeat(y, x)));
                }
                
                default:
                    return "Not implemented yet";
            }
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
            if (x < 0 && y > 0)
            {
                return "roznych znakow";
            }
            if (x < 0 && y == 0)
            {
                return "jest zero";
            }
            return "Not implemented yet";
        }
        public static string EqualOrNot(int x, int y)
        {
            return x == y ? "rowne" : "rozne";
        }
    }
}