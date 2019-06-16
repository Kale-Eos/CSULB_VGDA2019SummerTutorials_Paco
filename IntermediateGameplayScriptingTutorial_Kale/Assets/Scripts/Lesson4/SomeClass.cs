using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass
{
    public int Add(int num1, int num2) // same name different parameter same signature
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2) // same name different parameter same signature
    {
        return str1 + str2;
    }
}
