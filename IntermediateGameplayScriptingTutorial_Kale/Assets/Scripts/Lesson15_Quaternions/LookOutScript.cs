using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookOutScript : MonoBehaviour
{
    // make object follow target object through rotation

    public Transform target;

    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);  // can pass new Vector3(0, 1, 0) as 2nd vector to tell up
    }
}
