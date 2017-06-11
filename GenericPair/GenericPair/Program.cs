using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPair
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, String> pair = Pair<int, string>.Of(1, "hello");
            int i = pair.First; // 1
            String s = pair.Second; // "hello"

            Pair<int, String> pair2 = Pair<int, string>.Of(1, "hello");
            bool mustBeTrue = pair.Equals(pair2); // true!
            bool mustAlsoBeTrue = pair.GetHashCode() == pair2.GetHashCode(); // true!

        }
    }
}
