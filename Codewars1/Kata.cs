using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars1
{
    class Kata
    {
        public string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToUpper().Where(char.IsLetter).Select(x => x - 64));
        }
    }
}
