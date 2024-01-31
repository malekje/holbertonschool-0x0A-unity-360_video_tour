using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FadeCanvas;

    private void OnEnable()
    {
        StartCoroutine(RemoveAfterSeconds(10, FadeCanvas));
    }
    IEnumerator RemoveAfterSeconds (int seconds, GameObject FadeCanvas)
    {
        yield return new WaitForSeconds(seconds);
        FadeCanvas.SetActive(false);
    }
}
