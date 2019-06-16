using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is Alive" : "Player is Dead"; // bool ? True : False
        // message = health > 0 ? "Player is Alive" : health == 0 ? "Player is barely alive" : "Player is Dead"; // true : conditional: false

        // second is cumbersome, only need if needed
        // ternary operationused fr quick if-else

    }
}
