﻿using Strategy_Pattern.Strategy_Pattern_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy_Pattern_1
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }

        public void End(StringBuilder sb)
        {

        }

        public void Start(StringBuilder sb)
        {

        }
    }
}
