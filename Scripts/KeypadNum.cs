using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadNum : MonoBehaviour
{
    public string number;
    public bool pressed = false;
    public bool canPress = true;
    public GameObject door;

    public void IsPressed()
    {
        if(canPress == true)
        {
            pressed = true;
            door.GetComponent<SafeCode>().codeEntered += number;
            door.GetComponent<SafeCode>().numberOfEnters++;
        }
    }

    public void CantPress()
    {
        canPress = false;
    }
}
