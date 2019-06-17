using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inheritance inherits classes to classes
// interface implements from classes

public interface IKillable
{
    // paramters running IKillable run voids below
    void Kill();
}

public interface IDamageable<T>
{
    // contains all constructs
    void Damage(T damageTaken);
}
