using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSetPosition : MonoBehaviour
{
    public PropertiesAndCoroutines coroutineScript;

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray, out hit);

        if (hit.collider.gameObject == gameObject)
        {
            coroutineScript.Target = hit.point;
        }
    }
}