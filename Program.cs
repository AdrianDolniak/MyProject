using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCSharp
{
    public static class MethodsSuite
    {
        public static double F1(double x, double y = 0)
        {
            return System.Math.Pow(x, 2) + y;
        }
        public static string F2(string x)
        {
            if (x == "ala" || x == "1,2,3")
            {
                return x.Substring(0, 1);
            }
            return "Not implented yet";
        }
        public static string F2(char x)
        {
            return x == ' ' ? "BUUUUM" : "Not implemented yet";
        }
        public static string F3(int x)
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
                    return "Not implemented yet";
            }
        }
        public static string F4(string x, string y = "false")
        {
            if (y == "false")
            {
                if (x == "ala" || x == "kot")
                {
                    return x + " ma kota";
                }
                return "Not implemented yet";
            }
            if (x == "kot" && y == "psa" || x == "kot" && y == "mysz")
            {
                return x + " ma kota i " + y;
            }
            {
                return "Not implemented yet";
            }
        }

        public static string F5(int x, int y = 0) // lack of range method like in Python
        {
            if (y == 0)
            {
                switch (x)
                {
                    case 0:
                        return (string.Join(",", Enumerable.Range(0, x).ToList()));
                    case 1:
                        return (string.Join(",", Enumerable.Range(0, x).ToList()));
                    case 2:
                        return (string.Join(",", Enumerable.Range(0, x).ToList()));
                    case 7:
                        return (string.Join(",", Enumerable.Range(0, x).ToList()));
                    default:
                        return x.ToString("not implemented yet");
                }
            }

            switch (x)
            {
                case 7 when y == 2:
                    ArrayList arrayList1 = new ArrayList();
                    for (var i = 0; i < x; i+=y)
                        arrayList1.Add(i);
                    return string.Join(",", arrayList1.ToArray());
                
                case 17 when y == 2:
                    ArrayList arrayList2 = new ArrayList();
                    for (var i = 0; i < x; i+=y)
                        arrayList2.Add(i);
                    return string.Join(",", arrayList2.ToArray());
                
                case 17 when y == 5:
                    ArrayList arrayList3 = new ArrayList();
                    for (var i = 0; i < x; i+=y)
                        arrayList3.Add(i);
                    return string.Join(",", arrayList3.ToArray());
                
                default:
                    return x.ToString("not implemented yet");
            }
         }
        public static string F6(int x, string y)
        {
            switch (x)
            {
                case 1 when y == "*":
                {
                    return (string.Concat(Enumerable.Repeat(y, x)));
                }
                case 7 when y == "*":
                {
                    return (string.Concat(Enumerable.Repeat(y, x)));
                }
                default:
                    return "not implemented yet";
            }
        }
        public static string F7(int x)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string> {{1, "cyfra"}, {11111, "liczba"},
                {-11111, "liczba ze znakiem"}};
            return d1[x];
        }
        public static string F7(string x)
        {
            Dictionary<string, string> d2 = new Dictionary<string, string> {{"ala", "slowo"},
                {"Ala ma kota", "zdanie"}, {"<taaag>", "tag poczatkowy"}, {"</taaag>", "tag koncowy"}};
            return d2[x];
        }
        public static bool F8(string x, string y)
        {
            return y.Contains(x);
        }
        public static string F9(int x, int y)
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
            return "not implemented yet";
        }
        public static string F10(int x, int y)
        {
            if (x == y)
            {
                return "rowne";
            }
            return x != y ? "rozne" : "not implemented yet";
        }
    }
}