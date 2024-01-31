using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBox : MonoBehaviour
{
    public GameObject CubeB;
    private bool activated = false;

    public void CubeBoxDisplay()
    {
        if (activated)
        {
            CubeB.SetActive(false);
            activated = false;
        }
        else
        {
            CubeB.SetActive(true);
            activated = true;
        }
    }
}
