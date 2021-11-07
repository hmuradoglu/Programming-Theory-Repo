using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private void OnMouseDown()
    {
        DisplayText();
    }

    public override void DisplayText()
    {
        Debug.Log("I'm a dog");
    }
}
