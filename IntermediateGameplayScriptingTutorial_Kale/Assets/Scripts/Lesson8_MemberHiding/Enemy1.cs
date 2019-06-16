using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Humanoid
{
    // hides the Humanoid parent version and runs both
    new public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}
