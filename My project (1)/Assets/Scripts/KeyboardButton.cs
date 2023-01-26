using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyboardButton : MonoBehaviour
{
    Keyboard keyboard;
    public TextMeshProUGUI buttonText;

     void Start()
     {
        keyboard = GetComponentInChildren<Keyboard>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();

        if(buttonText.text.Length == 1)
        {
            NameToText();
            GetComponentInChildren<ButtonVR>().onRelease.AddListener(delegate { keyboard.InsertCharacter(buttonText.text); });
        }
     }

    public void NameToText()
    {
        buttonText.text = gameObject.name;
        
    }
}
