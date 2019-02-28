using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                //Loop though each letter and insert space before a uppercase letter
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim(); //Removes any spaces before adding one. To make sure there are not more than one space
                        result += " "; //Adds the space
                    }
                    result += letter;
                }
                result = result.Trim();
            }

            return result;
        } //The "this" before string, extends the string type, so now the method can be called from all strings directly
    }
}
