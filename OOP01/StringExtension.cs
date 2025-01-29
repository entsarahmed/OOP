using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    public static class StringExtension
    {
        public  static string ToFirstUpper(this string str)
        {

            char[] charArray = str.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);    
            return str.ToString();

        }
    }
}
