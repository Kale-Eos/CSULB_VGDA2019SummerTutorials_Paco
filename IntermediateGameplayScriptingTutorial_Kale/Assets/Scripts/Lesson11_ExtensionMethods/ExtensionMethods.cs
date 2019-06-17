using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// must be used in only non generic methods static class
// used like instance method
// uses this

public static class ExtensionMethods
{
    public static void ResetTransformation(this Transform trans)
        // more parameters, just remove 'this'
    {
        // becomes the instance of parameter
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}