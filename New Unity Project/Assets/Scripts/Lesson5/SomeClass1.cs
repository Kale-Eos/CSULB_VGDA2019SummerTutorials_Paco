using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass1
{
    public T GenericMethod<T>(T param)
        // access function
        
        // class - reference type
        // struct - value type
        // new() - public constructor no paramters
        // class name -- ie: Monbehavior -- to make it that type or polymorthism to make that class type
        // interface -- ie: IEnumerable -- to make it the interface
    {
        return param; // param can be float, anything, even class
    }
}
