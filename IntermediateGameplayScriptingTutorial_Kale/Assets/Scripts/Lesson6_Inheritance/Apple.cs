using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    // child of fruit

    // 1st constructor
    public Apple()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    // 2nd constructor
    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
