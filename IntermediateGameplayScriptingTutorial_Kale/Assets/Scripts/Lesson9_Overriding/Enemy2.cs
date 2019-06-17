using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Humanoid1
{
    // child version where it will add Humanoid with custom Enemy2 elements
    public override void Yell()
    {
        base.Yell();
        // raises hands to mouth
        // Play "Yelling Sound"
    }
}
