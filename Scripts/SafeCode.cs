using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SafeCode : MonoBehaviour
{
    [Header("Keypad Buttons")]
    public GameObject number1;
    public GameObject number2;
    public GameObject number3;
    public GameObject number4;
    public GameObject number5;
    public GameObject number6;
    public GameObject number7;
    public GameObject number8;
    public GameObject number9;

    public int numberOfEnters = 0;
    public bool isCodeCorrect = false;
    public string correctCode = "3597";
    public string codeEntered = "";
    public GameObject self;


    private void Update()
    {
        if (numberOfEnters >= 4 && isCodeCorrect == false)
        {
            numberOfEnters = 0;
            codeEntered = "";
            number1.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number2.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number3.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number4.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number5.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number6.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number7.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number8.GetComponent<ChangeMaterial>().SetOriginalMaterial();
            number9.GetComponent<ChangeMaterial>().SetOriginalMaterial();
        }
        else if(numberOfEnters >= 4 && isCodeCorrect == true)
        {
            Debug.Log("Correct Code Entered");
            self.GetComponent<XRGrabInteractable>().enabled = true;
        }
        else
        {
            self.GetComponent<XRGrabInteractable>().enabled = false;
        }

        if(codeEntered == correctCode)
        {
            isCodeCorrect = true;
        }
    }
}
