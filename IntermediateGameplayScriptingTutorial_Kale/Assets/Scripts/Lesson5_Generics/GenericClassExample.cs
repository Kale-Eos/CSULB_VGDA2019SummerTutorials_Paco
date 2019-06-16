using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        // call as if from old into new

        myClass.UpdatedItem(5);

        // used for collections and library systems
    }
}
