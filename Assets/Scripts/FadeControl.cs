using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{
    public GameObject FadeCanvas;

    public void DisplayFader()
    {
        FadeCanvas.SetActive(true);
    }

}
