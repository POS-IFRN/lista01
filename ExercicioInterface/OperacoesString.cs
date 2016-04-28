using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    static class OperacoesString
    {
        public static int WordCount(this string t)
        {
            Regex re = new Regex("\\ +");
            return re.Split(t).Length;
        }

        public static string ReversePhrase(this string t)
        {
            return new string(t.Reverse().ToArray());
        }

        public static string GeneratePassword(this string t)
        {
            Regex re = new Regex("\\ +");
            string pass = string.Empty;
            foreach (string s in re.Split(t))
            {
                pass += s.Length;
            }
            return pass;
        }

        public static string PhraseFirstLetters(this string t)
        {
            Regex re = new Regex("\\ +");
            string initials = string.Empty;
            foreach (string s in re.Split(t))
            {
                initials += s[0];
            }
            return initials;
        }
    }
}
