using System;
using System.Collections.Generic;

namespace CCIConsoleApp.ArraysandString
{
    public class IsUnique : Question
    {
        public IsUnique()
        {
        }

        private bool IsUniQueChars(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            var checker = 0;

            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] - 'a';

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1 << val);
            }
            return true;

        }


        private bool IsUniqueChars2(string str)
        {
            var hashSet = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashSet.Contains(c))
                {
                    return false;
                }

                hashSet.Add(c);
            }
            return true;
        }

        public override void Run()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };
            foreach(var word in words)
            {
                Console.WriteLine(word +": " + IsUniQueChars(word) + " " + IsUniqueChars2(word));
            }
            Console.ReadLine();
        }

    }
}
