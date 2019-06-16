using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(1, 2);
        myClass.Add("Hello", "World");

        // conditions follwowed are
        // 1. Exact match
        // 2. least conversion
    }
}