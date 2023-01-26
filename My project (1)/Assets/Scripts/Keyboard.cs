using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keyboard : MonoBehaviour
{

    public TMP_InputField inputField;
    public GameObject normalButton;
    public GameObject capsButton;
    public bool caps;

    public void Start()
    {
        caps = false;
    }

    public void InsertCharacter(string c)
    {
        inputField.text += c;
    }

    public void DeleteCharacter()
    {
        if(inputField.text.Length > 0 )
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }

    public void InsertSpace()
    {
        inputField.text += " ";
    }

    public void CapsPressed()
    {
        if(!caps)
        {
            normalButton.SetActive(false);
            capsButton.SetActive(true);
            caps = true;
        }
        else
        {
            capsButton.SetActive(false);
            normalButton.SetActive(true);
            caps = false;
        }
    }
}
