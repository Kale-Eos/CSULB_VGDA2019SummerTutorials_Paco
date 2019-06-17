using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotationScript : MonoBehaviour
{
    // rotation set 0

    void Start()
    {
        transform.rotation = Quaternion.identity;
    }
}
