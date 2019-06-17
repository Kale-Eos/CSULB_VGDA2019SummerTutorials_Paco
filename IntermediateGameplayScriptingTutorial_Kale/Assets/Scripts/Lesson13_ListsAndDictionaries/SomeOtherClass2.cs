using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass2 : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        badguys.Add("gangster", bg1);   // name for key
        badguys.Add("mutant", bg2);     // name for key

        BadGuy magneto = badguys["mutant"]; // attaching key to type

        BadGuy temp = null;

        if (badguys.TryGetValue("birds", out temp))
        {
            // success!
        }

        else
        {
            // failure!
        }
    }
}
