using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass1 : MonoBehaviour
{
    void Start()
    {
        SomeClass1 myClass = new SomeClass1();

        myClass.GenericMethod<int>(5); // can use generic method as call like any other
        // used for data structure
    }
}
