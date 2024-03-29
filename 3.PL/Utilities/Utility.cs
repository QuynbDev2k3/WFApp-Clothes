﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.PL.Utilities
{
    public class Utility
    {
        // Check là số
        public static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        // Loại bỏ dấu tiếng việt
        public static string LoaiBoDauTiengViet(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            sb = sb.Replace('ê', 'e');
            sb = sb.Replace("Ê", "E");
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
        public static bool CheckStringEmpty(string x)
        {
            if(x == String.Empty)
            {
                return true;
            }
            else return false;
        }
        public static bool CheckNumber(string temp)
        {
            int n;
            return int.TryParse(temp, out n);    
        }
        public static bool CheckSDT(string temp)
        {
            if (Regex.Match(temp, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$").Success) return true;
            else return false;
        }
    }
}
