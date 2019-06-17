using System.Collections;
using System.Collections.Generic; // needs this fro lists and dictionaries
using UnityEngine;

public class SomeClass3 : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        // badguys[0]           // can be accessed as an array
        // badguys.Count()      // works as length in array
        // badguys.RemoveAt()   // removes index from list and moves everything accordingly
        // badguys.Insert()     // inserts index and shift accordingly
        // badguys.Sort()       // reorganizes indexs of same type using i comparable

        badguys.Sort();

        foreach(BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear(); // starts with fresh list
        // dictionaries work like lists but have two types using KVP
        // uses collection of values
    }
}
