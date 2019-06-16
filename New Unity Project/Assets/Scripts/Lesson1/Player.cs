using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int experience;

    public int Experience
    {
        get // referenced only available in public
        {
            // other code here
            return experience;
        }

        set // allocated only available in public
        {
            // other code here
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000; // numerical level, not actual experience
        }

        set
        {
            experience = value * 1000; // save actual experience attained
        }
    }

    public int Health { get; set;} // shorthand == field
}
