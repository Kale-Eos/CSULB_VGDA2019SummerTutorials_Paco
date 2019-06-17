using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note only Yspeed was used in tutorial
// made edits because I wanted to

[ExecuteInEditMode]
public class SpinScript : MonoBehaviour
{
    [Range(-100, 100)] public int Xspeed = 0;    // creates sliders in edit
    [Range(-100, 100)] public int Yspeed = 0;    // creates sliders in edit
    [Range(-100, 100)] public int Zspeed = 0;    // creates sliders in edit

    void Update()
    {
        transform.Rotate(new Vector3(Xspeed * Time.deltaTime, 0, 0));
        transform.Rotate(new Vector3(0, Yspeed * Time.deltaTime, 0));
        transform.Rotate(new Vector3(0, 0, Zspeed * Time.deltaTime));
    }
}
