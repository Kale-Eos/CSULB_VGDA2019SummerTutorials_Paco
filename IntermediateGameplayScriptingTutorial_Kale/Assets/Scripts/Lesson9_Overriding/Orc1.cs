using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc1 : Enemy2
{
    // child version of Enemy2 and it will add Humanoid and Enemy2 with custom Orc1 elements
    public override void Yell()
    {
        base.Yell();
        // raises hands to mouth
        // Play "Yelling Sound"
    }
}
