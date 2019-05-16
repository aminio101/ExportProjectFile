using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TvUnicode
/// </summary>
public class TvUnicode
{
    public TvUnicode()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string ConvertToTVUnicode(string str)
    {
        if (str == "" || str == null)
            return "";
        string str_unicode = "";
        bool befor = false;
        bool after = false;
        string charecter = "";
        var len = str.Length;
        for (var i = 0; i < len; i++)
        {
            charecter = str.Substring(i, 1);
            after = true;
            if (i + 1 != len)
            {
                if (str.Substring(i + 1, 1) == " ")
                    after = false;
                else if (str.Substring(i + 1, 1) == ".")
                    after = false;
                else if (str.Substring(i + 1, 1) == ":")
                    after = false;
                else if (str.Substring(i + 1, 1) == "،")
                    after = false;
                else if (str.Substring(i + 1, 1) == ",")
                    after = false;
                else if (str.Substring(i + 1, 1) == "!")
                    after = false;
                else if (str.Substring(i + 1, 1) == "@")
                    after = false;
                else if (str.Substring(i + 1, 1) == "#")
                    after = false;
                else if (str.Substring(i + 1, 1) == "$")
                    after = false;
                else if (str.Substring(i + 1, 1) == "%")
                    after = false;
                else if (str.Substring(i + 1, 1) == "^")
                    after = false;
                else if (str.Substring(i + 1, 1) == "&")
                    after = false;
                else if (str.Substring(i + 1, 1) == "*")
                    after = false;
                else if (str.Substring(i + 1, 1) == "(")
                    after = false;
                else if (str.Substring(i + 1, 1) == ")")
                    after = false;
                else if (str.Substring(i + 1, 1) == "?")
                    after = false;
                else if (str.Substring(i + 1, 1) == "؟")
                    after = false;
                else if (str.Substring(i + 1, 1) == "<")
                    after = false;
                else if (str.Substring(i + 1, 1) == ">")
                    after = false;
                else if (str.Substring(i + 1, 1) == "_")
                    after = false;
                else if (str.Substring(i + 1, 1) == "-")
                    after = false;
                else if (str.Substring(i + 1, 1) == "\"")
                    after = false;
                else if (str.Substring(i + 1, 1) == "/")
                    after = false;
                else if (str.Substring(i + 1, 1) == "'")
                    after = false;
                else if (str.Substring(i + 1, 1) == "\\")
                    after = false;
                else if (str.Substring(i + 1, 1) == "|")
                    after = false;
                else if (str.Substring(i + 1, 1) == "»")
                    after = false;
                else if (str.Substring(i + 1, 1) == "«")
                    after = false;
                else if (str.Substring(i + 1, 1) == "؛")
                    after = false;
                else if (str.Substring(i + 1, 1) == "ء")
                    after = false;
                if (Convert.ToChar(str.Substring(i + 1, 1)) == Convert.ToChar(8204))
                    after = false;



            }
            else
                after = false;
            switch (charecter)
            {
                case "ّ":
                case "ُ":
                case "َ":
                case "ٍ":
                case "ٌ":
                case "ً":
                case "ء":
                    str_unicode += "";
                    befor = false;
                    break;
                case "،":
                    str_unicode += "\ufd83";
                    befor = false;
                    break;
                case "‌":
                    str_unicode += "‌";
                    befor = false;
                    break;
                case "؟":
                    str_unicode += "\ufd82";
                    befor = false;
                    break;
                case "؛":
                    str_unicode += ";";
                    befor = false;
                    break;
                case "آ":
                    if (!befor)
                        str_unicode += "\ufd51";
                    else
                        str_unicode += "\ufe82";
                    befor = false;
                    break;
                case "أ":
                case "إ":
                case "ا":
                    if (!befor)
                        str_unicode += "\ufd56";
                    else
                        str_unicode += "\ufe8e";
                    befor = false;
                    break;
                case "ب":
                    if (!after && !befor)
                        str_unicode += "\ufd57";
                    else if (befor && after)
                        str_unicode += "\ufe92";
                    else if (befor)
                        str_unicode += "\ufe90";
                    else
                        str_unicode += "\ufe91";
                    befor = after;
                    break;
                case "پ":
                    if (!after && !befor)
                        str_unicode += "\ufd7d";
                    else if (befor && after)
                        str_unicode += "\ufb59";
                    else if (befor)
                        str_unicode += "\ufb57";
                    else
                        str_unicode += "\ufb58";
                    befor = after;
                    break;
                case "ت":
                    if (!after && !befor)
                        str_unicode += "\ufd59";
                    else if (befor && after)
                        str_unicode += "\ufe98";
                    else if (befor)
                        str_unicode += "\ufe96";
                    else
                        str_unicode += "\ufe97";
                    befor = after;
                    break;
                case "ث":
                    if (!after && !befor)
                        str_unicode += "\ufd5a";
                    else if (befor && after)
                        str_unicode += "\ufe9c";
                    else if (befor)
                        str_unicode += "\ufe9a";
                    else
                        str_unicode += "\ufe9b";
                    befor = after;
                    break;
                case "ج":
                    if (!after && !befor)
                        str_unicode += "\ufd5b";
                    else if (befor && after)
                        str_unicode += "\ufea0";
                    else if (befor)
                        str_unicode += "\ufe9e";
                    else
                        str_unicode += "\ufe9f";
                    befor = after;
                    break;
                case "چ":
                    if (!after && !befor)
                        str_unicode += "\ufd7e";
                    else if (befor && after)
                        str_unicode += "\ufb7d";
                    else if (befor)
                        str_unicode += "\ufb7b";
                    else
                        str_unicode += "\ufb7c";
                    befor = after;
                    break;
                case "ح":
                    if (!after && !befor)
                        str_unicode += "\ufd5c";
                    else if (befor && after)
                        str_unicode += "\ufea4";
                    else if (befor)
                        str_unicode += "\ufea2";
                    else
                        str_unicode += "\ufea3";
                    befor = after;
                    break;
                case "خ":
                    if (!after && !befor)
                        str_unicode += "\ufd5d";
                    else if (befor && after)
                        str_unicode += "\ufea8";
                    else if (befor)
                        str_unicode += "\ufea6";
                    else
                        str_unicode += "\ufea7";
                    befor = after;
                    break;
                case "د":
                    if (!befor)
                        str_unicode += "\ufd5e";
                    else
                        str_unicode += "\ufeaa";
                    befor = false;
                    break;
                case "ذ":
                    if (!befor)
                        str_unicode += "\ufd5f";
                    else
                        str_unicode += "\ufeac";
                    befor = false;
                    break;
                case "ر":
                    if (!befor)
                        str_unicode += "\ufd60";
                    else
                        str_unicode += "\ufeae";
                    befor = false;
                    break;
                case "ز":
                    if (!befor)
                        str_unicode += "\ufd61";
                    else
                        str_unicode += "\ufeb0";
                    befor = false;
                    break;
                case "ژ":
                    if (!befor)
                        str_unicode += "\ufd7f";
                    else
                        str_unicode += "\ufb8b";
                    befor = false;
                    break;
                case "س":
                    if (!after && !befor)
                        str_unicode += "\ufd62";
                    else if (befor && after)
                        str_unicode += "\ufeb4";
                    else if (befor)
                        str_unicode += "\ufeb2";
                    else
                        str_unicode += "\ufeb3";
                    befor = after;
                    break;
                case "ش":
                    if (!after && !befor)
                        str_unicode += "\ufd63";
                    else if (befor && after)
                        str_unicode += "\ufeb8";
                    else if (befor)
                        str_unicode += "\ufeb6";
                    else
                        str_unicode += "\ufeb7";
                    befor = after;
                    break;
                case "ص":
                    if (!after && !befor)
                        str_unicode += "\ufd64";
                    else if (befor && after)
                        str_unicode += "\ufebc";
                    else if (befor)
                        str_unicode += "\ufeba";
                    else
                        str_unicode += "\ufebb";
                    befor = after;
                    break;
                case "ض":
                    if (!after && !befor)
                        str_unicode += "\ufd65";
                    else if (befor && after)
                        str_unicode += "\ufec0";
                    else if (befor)
                        str_unicode += "\ufebe";
                    else
                        str_unicode += "\ufebf";
                    befor = after;

                    break;
                case "ط":
                    if (!after && !befor)
                        str_unicode += "\ufd66";
                    else if (befor && after)
                        str_unicode += "\ufec4";
                    else if (befor)
                        str_unicode += "\ufec2";
                    else
                        str_unicode += "\ufec3";
                    befor = after;
                    break;
                case "ظ":
                    if (!after && !befor)
                        str_unicode += "\ufd67";
                    else if (befor && after)
                        str_unicode += "\ufec8";
                    else if (befor)
                        str_unicode += "\ufec6";
                    else
                        str_unicode += "\ufec7";
                    befor = after;
                    break;
                case "ع":
                    if (!after && !befor)
                        str_unicode += "\ufd68";
                    else if (befor && after)
                        str_unicode += "\ufecc";
                    else if (befor)
                        str_unicode += "\ufeca";
                    else
                        str_unicode += "\ufecb";
                    befor = after;
                    break;
                case "غ":
                    if (!after && !befor)
                        str_unicode += "\ufd69";
                    else if (befor && after)
                        str_unicode += "\ufed0";
                    else if (befor)
                        str_unicode += "\ufece";
                    else
                        str_unicode += "\ufecf";
                    befor = after;
                    break;
                case "ف":
                    if (!after && !befor)
                        str_unicode += "\ufd6b";
                    else if (befor && after)
                        str_unicode += "\ufed4";
                    else if (befor)
                        str_unicode += "\ufed2";
                    else
                        str_unicode += "\ufed3";
                    befor = after;
                    break;
                case "ق":
                    if (!after && !befor)
                        str_unicode += "\ufd6c";
                    else if (befor && after)
                        str_unicode += "\ufed8";
                    else if (befor)
                        str_unicode += "\ufed6";
                    else
                        str_unicode += "\ufed7";
                    befor = after;
                    break;
                case "ك":
                case "ک":
                    if (!after && !befor)
                        str_unicode += "\ufd6d";
                    else if (befor && after)
                        str_unicode += "\ufb91";
                    else if (befor)
                        str_unicode += "\ufb8f";
                    else
                        str_unicode += "\ufb90";
                    befor = after;
                    break;
                case "گ":
                    if (!after && !befor)
                        str_unicode += "\ufd80";
                    else if (befor && after)
                        str_unicode += "\ufb95";
                    else if (befor)
                        str_unicode += "\ufb93";
                    else
                        str_unicode += "\ufb94";
                    befor = after;
                    break;
                case "ل":
                    if (!after && !befor)
                        str_unicode += "\ufd6e";
                    else if (befor && after)
                        str_unicode += "\ufee0";
                    else if (befor)
                        str_unicode += "\ufede";
                    else
                        str_unicode += "\ufedf";
                    befor = after;
                    break;
                case "م":
                    if (!after && !befor)
                        str_unicode += "\ufd6f";
                    else if (befor && after)
                        str_unicode += "\ufee4";
                    else if (befor)
                        str_unicode += "\ufee2";
                    else
                        str_unicode += "\ufee3";
                    befor = after;
                    break;
                case "ن":
                    if (!after && !befor)
                        str_unicode += "\ufd70";
                    else if (befor && after)
                        str_unicode += "\ufee8";
                    else if (befor)
                        str_unicode += "\ufee6";
                    else
                        str_unicode += "\ufee7";
                    befor = after;
                    break;
                case "و":
                    if (!befor)
                        str_unicode += "\ufd72";
                    else
                        str_unicode += "\ufeee";
                    befor = false;
                    break;
                case "ه":
                    if (!after && !befor)
                        str_unicode += "\ufd71";
                    else if (befor && after)
                        str_unicode += "\ufeec";
                    else if (befor)
                        str_unicode += "\ufeea";
                    else
                        str_unicode += "\ufeeb";
                    befor = after;
                    break;
                case "ي":
                case "ی":
                    if (!after && !befor)
                        str_unicode += "\ufd73";
                    else if (befor && after)
                        str_unicode += "\ufbff";
                    else if (befor)
                        str_unicode += "\ufbfd";
                    else
                        str_unicode += "\ufbfe";
                    befor = after;
                    break;
                case "ئ":
                    if (!after && !befor)
                        str_unicode += "\ufd55";
                    else if (befor && after)
                        str_unicode += "\ufe8c";
                    else if (befor)
                        str_unicode += "\ufe8a";
                    else
                        str_unicode += "\ufe8b";
                    befor = after;
                    break;
                default:
                    str_unicode += charecter;
                    break;
            }
        }
        return str_unicode;
    }
}