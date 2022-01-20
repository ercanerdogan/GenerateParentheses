using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateParentheses
{
    
    class Program
    {
        private const char openBracket = '(';
        private const char closeBracket = ')';
        private static IList<string> result;
        public static IList<string> GenerateParenthesis(int n)
        {
            result = new List<string>();
            GenerateParenthesisRecur(n, n, new StringBuilder());
            return result;
        }

        private static void GenerateParenthesisRecur(int open, int close, StringBuilder strBuilder)
        {
            if (open == 0 && close == 0)
            {
                result.Add(strBuilder.ToString());
                return;
            }

            if (open > 0)
            {
                strBuilder.Append(openBracket);
                GenerateParenthesisRecur(open - 1, close, strBuilder);
                strBuilder.Remove(strBuilder.ToString().Length - 1, 1);
            }

            if (open < close)
            {
                strBuilder.Append(closeBracket);
                GenerateParenthesisRecur(open, close - 1, strBuilder);
                strBuilder.Remove(strBuilder.ToString().Length - 1, 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var res = GenerateParenthesis(n);

            foreach (var item in res)
            {
                Console.WriteLine(item);

            }
        }
    }
}
