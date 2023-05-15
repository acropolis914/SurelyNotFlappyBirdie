using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScr : MonoBehaviour
{
    public GameObject canvasToShow;
    public int scoreThreshold = 5;
    private bool canvasShown = false;

    private void Update()
    {
        if (Score.score >= scoreThreshold && !canvasShown)
        {
            canvasToShow.SetActive(true);
            canvasShown = true;
        }
    }
}
