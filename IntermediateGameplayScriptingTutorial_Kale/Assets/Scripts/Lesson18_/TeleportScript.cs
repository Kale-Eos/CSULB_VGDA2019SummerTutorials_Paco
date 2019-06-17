using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += Teleport; // subscribe to method
    }

    void OnDisable()
    {
        EventManager.OnClicked -= Teleport; // unsubscribed to method
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
