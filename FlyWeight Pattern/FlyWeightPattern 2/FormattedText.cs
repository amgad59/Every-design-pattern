﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern.FlyWeightPattern_2
{
    public class FormattedText
    {
        private string plainText;
        private bool[] capitalize;
        public FormattedText(string plainText)
        {
            this.plainText = plainText;
            capitalize = new bool[plainText.Length];
        }
        public void Capitalize(int start,int end)
        {
            for(int i = start; i < end; i++)
            {
                capitalize[i] = true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < plainText.Length; i++)
            {
                var c = plainText[i];
                sb.Append(capitalize[i] ? char.ToUpper(c) : c);
            }
            return sb.ToString();
        }
    }
}
