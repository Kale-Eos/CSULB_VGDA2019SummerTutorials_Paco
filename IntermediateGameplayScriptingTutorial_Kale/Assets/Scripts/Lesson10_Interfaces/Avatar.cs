using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    // must define both
    // interfacing multiple interfaces is possible, but not possible in inheriting for unrelation

    // needed for IKillable
    public void Kill()
    {
        // does something
    }

    // needed for IDamageable
    public void Damage(float damageTaken)
    {
        // does something
    }
}
