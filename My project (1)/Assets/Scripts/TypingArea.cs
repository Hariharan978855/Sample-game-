using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypingArea : MonoBehaviour
{

    public GameObject lefttHand;
    public GameObject rightHand;
    public GameObject rightTypingHand;
    public GameObject leftTypingHand;

    private void OnTriggerEnter(Collider other)
    {
        GameObject hand = GetComponentInChildren<OVRGrabber>().gameObject;

        if (hand == null) return;

        if(hand == lefttHand)
        {
            leftTypingHand.SetActive(true);
        }
        else if(hand == rightHand)
        {
            rightTypingHand.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject hand = GetComponentInChildren<OVRGrabber>().gameObject;

        if (hand == null) return;

        if (hand == lefttHand)
        {
            leftTypingHand.SetActive(false);
        }
        else if (hand == rightHand)
        {
            rightTypingHand.SetActive(false);
        }

    }
}
