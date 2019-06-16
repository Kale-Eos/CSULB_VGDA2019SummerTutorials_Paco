using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass <T>
{
    T item; // uses intance item type of type T

    public void UpdatedItem(T newItem)
    {
        item = newItem; // assigns newItem from item
    }
}
