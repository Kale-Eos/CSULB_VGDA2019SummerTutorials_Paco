using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int enemyCount = 0; // conditional for being specific for the specific public class

    void Start()
    {
        enemyCount++;
    }
}
