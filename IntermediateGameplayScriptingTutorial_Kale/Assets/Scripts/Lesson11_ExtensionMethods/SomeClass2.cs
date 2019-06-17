using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass2 : MonoBehaviour
{
    void Start()
    {
        // no method setup can just pull in due to Extension Method
        transform.ResetTransformation();
    }
}
