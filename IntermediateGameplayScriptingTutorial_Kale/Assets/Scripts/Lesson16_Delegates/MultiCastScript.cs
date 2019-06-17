using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnGreen;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    // original used from tutorial
    //void TurnGreen()
    //{
    //    GetComponent<Renderer>().material.color = Color.green;
    //}

    //added following part to see function delayed
    void TurnGreen()
    {
        StartCoroutine(TurningGreen());
    }

    IEnumerator TurningGreen()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<Renderer>().material.color = Color.green;
    }
}
