using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    // variables contain data
    // delegates contain functions

    delegate void MyDelegate(int num);  // delegate parameters
    MyDelegate myDelegate;              // member variable

    void Start()
    {
        myDelegate = PrintNum;          // sets number
        myDelegate(50);                 // sets 50

        myDelegate = DoubleNum;         // function to param
        myDelegate(50);                 // increment amount
    }

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}
