// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of ByteE using cast expr
// </Description> 
// <RelatedBugs> </RelatedBugs>  
//<Expects Status=success></Expects>
// <Code> 


using System.Runtime.InteropServices;
using System;

internal class NullableTest
{
    private static bool BoxUnboxToNQ<T>(T o)
    {
        return Helper.Compare((ByteE)(ValueType)(object)o, Helper.Create(default(ByteE)));
    }

    private static bool BoxUnboxToQ<T>(T o)
    {
        return Helper.Compare((ByteE?)(ValueType)(object)o, Helper.Create(default(ByteE)));
    }

    private static int Main()
    {
        ByteE? s = Helper.Create(default(ByteE));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


