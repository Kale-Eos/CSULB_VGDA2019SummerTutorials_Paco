using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy1
{
    // hides both Humanoid and Enemy1 version and runs all
    new public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}
