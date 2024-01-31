using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MezzanineBox2 : MonoBehaviour
{
    public GameObject MezzanineB2;
    private bool activated = false;

    public void MezzanineBox2Display()
    {
        if (activated)
        {
            MezzanineB2.SetActive(false);
            activated = false;
        }
        else
        {
            MezzanineB2.SetActive(true);
            activated = true;
        }
    }
}
