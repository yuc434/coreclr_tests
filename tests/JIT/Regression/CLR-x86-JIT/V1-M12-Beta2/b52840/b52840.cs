// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Test
{
    using System;

    public class App
    {
        private static byte s_b;
        private static void Func(ref String s) { }
        private static void Main1()
        {
            Func(ref __refvalue(__makeref(s_b), String[])[0]);
        }
        public static int Main()
        {
            try
            {
                Main1();
                return 1;
            }
            catch (InvalidCastException)
            {
                return 100;
            }
        }
    }
}
