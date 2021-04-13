using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SUPER_STRING
{
    static class SuperString
    {
        public static string DefLanguage(this string str)
        {

            if (Regex.IsMatch(str, "^[a-zA-Z]*$"))
                str = "ENG";
            else if (Regex.IsMatch(str, "^[а-яА-Я]*$"))
                str = "RU";
            else if (Regex.IsMatch(str, "^[a-zA-Z0-9а-яА-Я0-9 ]*$"))
                str = "MIX";
            else str = "MIX";


            /*            switch (str)
                        {
                            case Regex.IsMatch(str, "^[a-zA-Z]*$"):
                                str = "ENG";
                                break;
                            default:
                                break;
                        }*/
            return str;
        }

    }
}
