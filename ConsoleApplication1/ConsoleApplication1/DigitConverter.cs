using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class DigitConverter
    {
        public static string toString(int _n)
        {
            string res = "";
            /* Если не требуется по заданию разгонять до таких чисел 191239123 на входе, или того что больше int, то оставляем на входе int */
            if (_n == 0)
            {
                res = "ноль";
                
                return res;
            }

            if (_n < 0)
            {
                res = "минус ";
                _n = -_n;
            }

            //тысяч
            switch (_n / 1000)
            {
                case 1: res = "одна тысяча "; break;
                case 2: res = "две тысячи "; break;
                case 3: res = "три тысячи "; break;
                case 4: res = "четыре тысячи "; break;
                case 5: res = "пять тысяч "; break;
                case 6: res = "шесть тысяч "; break;
                case 7: res = "семь тысяч "; break;
                case 8: res = "восемь тысяч "; break;
                case 9: res = "девять тысяч "; break;
            }

            //сотен
            switch ((_n / 100) % 10)
            {
                case 1: res += "сто "; break;
                case 2: res += "двести "; break;
                case 3: res += "триста "; break;
                case 4: res += "четыреста "; break;
                case 5: res += "пятьсот "; break;
                case 6: res += "шестьсот "; break;
                case 7: res += "семьсот "; break;
                case 8: res += "восемьсот "; break;
                case 9: res += "девятьсот "; break;
            }

            //десятков
            switch ((_n / 10) % 10)
            {
                case 1:
                    {
                        switch (_n % 10)
                        {
                            case 0: res += "десять"; break;
                            case 1: res += "одиннадцать"; break;
                            case 2: res += "двенадцать"; break;
                            case 3: res += "тринадцать"; break;
                            case 4: res += "четырнадцать"; break;
                            case 5: res += "пятнадцать"; break;
                            case 6: res += "шестнадцать "; break;
                            case 7: res += "семнадцать"; break;
                            case 8: res += "восемнадцать"; break;
                            case 9: res += "девятнадцать"; break;
                        }
                        
                        return res;
                    }
                case 2: res += "двадцать "; break;
                case 3: res += "тридцать "; break;
                case 4: res += "сорок "; break;
                case 5: res += "пятьдесят "; break;
                case 6: res += "шестьдесят "; break;
                case 7: res += "семьдесят "; break;
                case 8: res += "восемьдесят "; break;
                case 9: res += "девяносто "; break;
            }

            //единиц
            switch (_n % 10)
            {
                case 1: res += "один"; break;
                case 2: res += "два"; break;
                case 3: res += "три"; break;
                case 4: res += "четыре"; break;
                case 5: res += "пять"; break;
                case 6: res += "шесть"; break;
                case 7: res += "семь"; break;
                case 8: res += "восемь"; break;
                case 9: res += "девять"; break;
            }

            return res;
        }
    }
}
