using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class Password : MonoBehaviour
{
    public TextMeshProUGUI passwordDisplay;
    public string correctPassword;
    public string code = null;
    public int numberOfInputs = 0;
    public bool passIsCorrect = false;
    public GameObject door;

    void Update()
    {
        if (numberOfInputs > 4)
        {
            passwordDisplay.text = "****";
            code = null;
            numberOfInputs = 0;
            passIsCorrect = false;
        }
        else if (passIsCorrect == true)
        {
            door.GetComponent<Rigidbody>().isKinematic = false;
            door.GetComponent<XRGrabInteractable>().enabled = true;
        }

        if (passwordDisplay.text == correctPassword)
        {
            passIsCorrect = true;
            passwordDisplay.text = "OPEN";
        }
    }

    public void UpdatePassword(string input)
    {
        code = code + input;
        passwordDisplay.text = code;
        numberOfInputs++;
    }

    public void CheckInteractions()
    {
        if(numberOfInputs > 4)
        {
            numberOfInputs = 0;
            code = null;
            passwordDisplay.text = "****";
        }
    }
}
