using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantinaBox : MonoBehaviour
{
    public GameObject CantinaB;
    private bool activated = false;

    public void CantinaBoxDisplay()
    {
        if (activated)
        {
            CantinaB.SetActive(false);
            activated = false;
        }
        else
        {
            CantinaB.SetActive(true);
            activated = true;
        }
    }
}
