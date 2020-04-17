using System;
using System.Collections.Generic;
using System.Text;

namespace quiz1gao
{
    public static class IntExtensions
    {
        public static bool IsDividableBy(this int i, int value)
        {
           return i % value == 0;
        }
    }
}
