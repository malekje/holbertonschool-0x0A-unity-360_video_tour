using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MezzanineBox1 : MonoBehaviour
{
    public GameObject MezzanineB1;
    private bool activated = false;

    public void MezzanineBox1Display()
    {
        if (activated)
        {
            MezzanineB1.SetActive(false);
            activated = false;
        }
        else
        {
            MezzanineB1.SetActive(true);
            activated = true;
        }
    }
}
