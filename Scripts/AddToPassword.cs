using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class AddToPassword : MonoBehaviour
{
    public GameObject passwordDisplay;
    public string number;

    private void Update()
    {
        if(passwordDisplay.GetComponent<Password>().passIsCorrect == true)
        {
            GetComponent<Button>().enabled = false;
        }
        else
        {
            GetComponent<Button>().enabled = true;
        }
    }

    public void AddInputToPassword()
    {
        passwordDisplay.GetComponent<Password>().UpdatePassword(number);
        passwordDisplay.GetComponent<Password>().CheckInteractions();
    }
}
