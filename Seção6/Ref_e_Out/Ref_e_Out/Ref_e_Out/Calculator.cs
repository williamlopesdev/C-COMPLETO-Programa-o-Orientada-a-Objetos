﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ref_e_Out
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
