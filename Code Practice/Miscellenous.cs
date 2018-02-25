using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Miscellenous
    {
        public static void PermutateString(string x)
        {
            int length = x.Length;
            char[] y = x.ToArray();
            RecurPermuteString(y, length, 0);
        }        

        public static int[] rotate(int[] arr, int d)
        {
            int[] x = new int[arr.Length];
            int y = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                y = i - d;
                if (y < 0)
                    y = arr.Length + y;
                x[y] = x[i];
            }

            return x;
        }

        /// <summary>
        /// Finds the Longest Consucutive sequence for the given array
        /// </summary>
        /// <param name="arr">Input array</param>
        public static void LongestConsecutiveSeq(int[] arr)
        {
            Dictionary<int, bool> inp = new Dictionary<int, bool>();
            int current, max = 0, count = 0;
            foreach (int x in arr)
            {
                inp.Add(x, true);

            }
            foreach(var y in inp)
            {
                current = y.Key;
                if (!inp.ContainsKey(current-1))
                { 
                    count = 1;
                    while (inp.ContainsKey(current + 1))
                    {
                        current = current + 1;
                        count = count + 1;
                    }
                    if (max < count) max = count;
                }
            }
            Console.WriteLine(max);

        }

        /// <summary>
        /// Finds the intersetion in 3 sorted arrays and prints it
        /// </summary>
        /// <param name="x">Input array 1</param>
        /// <param name="y">Input array 2</param>
        /// <param name="z">Input array 3</param>
        public static void FindIntersection(int[] x, int[] y, int[] z)
        {
            int xl = 0, yl = 0, zl = 0;
            while (true)
            {
                if (x[xl] == y[yl] && y[yl] == z[zl])
                {
                    Console.WriteLine(x[xl] + " ");
                    xl++;
                    yl++;
                    zl++;
                }
                else if (x[xl] < y[yl])
                    xl++;
                else if (y[yl] < z[zl])
                    yl++;
                else
                    zl++;
                if (xl == x.Length || zl == z.Length || yl == y.Length)
                    break;
            }
        }

        /// <summary>
        /// takes an string as an input and checks if the parenthesis are valid or not
        /// Result is displayed as text in console
        /// </summary>
        /// <param name="input">Input String</param>
        public static void ValidataParenthesis(string input)
        {
            System.Collections.Stack s = new System.Collections.Stack();
            Dictionary<char, char> parenthesisPair = new Dictionary<char, char>();
            parenthesisPair.Add('}', '{');
            parenthesisPair.Add(')', '(');
            parenthesisPair.Add(']', '[');
            char temp;
            foreach (char x in input)
            {
                if (x == '(' || x == '{' || x == '[')
                {
                    s.Push(x);
                }
                else if (x == '}' || x == ')' || x == ']')
                {
                    temp = Convert.ToChar(s.Pop());
                    if(parenthesisPair[x] != temp)
                    {
                        Console.WriteLine("Doesn't Match");
                        return;
                    }
                }
            }
            if(s.Count > 0)
            {
                Console.WriteLine("Doesn't Match");
                return;
            }
            Console.WriteLine("Valid Parenthesis");
        }

        public static void KthMostFrequentEement(int[] arr,int k)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            Dictionary<int, List<int>> temp2 = new Dictionary<int, List<int>>();
            int count = 0;
            int length = arr.Length;
            foreach (int x in arr)
            {
                if (temp.ContainsKey(x))
                    temp[x]++;
                else
                    temp[x] = 1;
            }
            foreach(var x in temp)
            {
                if (temp2.ContainsKey(x.Value))
                {
                    temp2[x.Value].Add(x.Key);
                }
                else
                {
                    temp2.Add(x.Value, new List<int> { x.Key });
                }
            }
            while(count < k)
            {
                if (temp2.ContainsKey(length))
                {
                    foreach (int x in temp2[length])
                    {
                        Console.WriteLine(x);
                    }
                    count += temp2[length].Count;
                }
                length--;
            }
        }

        /// <summary>
        /// Private class to recur the permutaiton of string
        /// </summary>
        /// <param name="x"></param>
        /// <param name="length"></param>
        /// <param name="position"></param>
        private static void RecurPermuteString(char[] x, int length, int position)
        {
            char tmp;
            if (length == position)
            {
                foreach (char c in x)
                    Console.Write(c);
                Console.WriteLine();
                return;
            }

            else
            {
                for (int i = position; i < length; i++)
                {
                    // swap 
                    tmp = x[i];
                    x[i] = x[position];
                    x[position] = tmp;

                    RecurPermuteString(x, length, position + 1);

                    tmp = x[i];
                    x[i] = x[position];
                    x[position] = tmp;
                }
            }
        }

        private static void StringCombination(char[] x, int length, int position)
        {
            char tmp;
            if (length == position)
            {
                for (int i = 0; i < position; i++)
                {
                    Console.Write(x[i]);
                }
                Console.WriteLine();
                return;
            }

            else
            {
                for (int i = 0; i < position; i++)
                {
                    Console.Write(x[i]);
                }

                Console.WriteLine();
                for (int i = position; i < length; i++)
                {
                    // swap 
                    tmp = x[i];
                    x[i] = x[position];
                    x[position] = tmp;

                    StringCombination(x, length, position + 1);

                    // swap
                    tmp = x[i];
                    x[i] = x[position];
                    x[position] = tmp;
                }
            }
        }

        
    }
}
