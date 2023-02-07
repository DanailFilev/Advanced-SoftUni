using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>(input);

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
