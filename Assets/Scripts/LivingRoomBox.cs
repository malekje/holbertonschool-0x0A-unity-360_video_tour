using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomBox : MonoBehaviour
{
    public GameObject LivingRoomB;
    private bool activated = false;
    
    public void LivingRoomBoxDisplay()
    {
        if (activated)
        {
            LivingRoomB.SetActive(false);
            activated = false;
        }
        else
        {
            LivingRoomB.SetActive(true);
            activated = true;
        }
    }
}
