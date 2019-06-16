using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        // setting inheritance with default constructors - 1st
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        // calling fruit
        myFruit.SayHello();
        myFruit.Chop();

        // calling apple
        myApple.SayHello();
        myApple.Chop();

        // setting inheritance with default constructors - 2nd
        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        // calling fruit
        myFruit.SayHello();
        myFruit.Chop();

        // calling apple
        myApple.SayHello();
        myApple.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
