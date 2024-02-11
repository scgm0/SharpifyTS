using System;
using System.Collections.Generic;

namespace SharpifyTS.Generators.Sample;

public class MyClass
{
    static MyClass()
    {
        var i = 0;
        TestValue c = i;
        Console.WriteLine(c.Value);
    }
}

[TSUnion(typeof(string), typeof(int), typeof(bool), typeof(string[]), typeof(int[]))]
public partial struct TestValue;