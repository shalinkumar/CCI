using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCIConsoleApp.ArraysandString
{
    public class CheckPermutation : Question
    {
        private bool IsPermutation(string original,string valueToTest)
        {
            if(original.Length != valueToTest.Length)
            {
                return false;
            }

            var originalAsArray = original.ToCharArray();
            Array.Sort(originalAsArray);
            original = new string(originalAsArray);

            var valueToTestAsArray = valueToTest.ToCharArray();
            Array.Sort(valueToTestAsArray);
            valueToTest = new string(valueToTestAsArray);

            return original.Equals(valueToTest);
        }

        private bool IsPermutation2(string original, string valueToTest)
        {
            if(original.Length != valueToTest.Length)
            {
                return false;
            }

            var letterCount = new Dictionary<char, int>();

            foreach(var character in original)
            {

            }
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
