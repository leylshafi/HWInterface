using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HWInterface.Models
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool HasDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckPassword(this string text)
        {
            if(text.Length>8 && text.Any(char.IsUpper) && text.Any(char.IsLower) && text.Any(char.IsDigit) && !text.Contains(" "))
            {
                return true;
            }
            return false;
        }

        public static string Capitalize(this string text)
        {
            text=text.Trim();
            text = Char.ToUpper(text[0])+text.Substring(1).ToLower();
            return text;
        }
    }
}
