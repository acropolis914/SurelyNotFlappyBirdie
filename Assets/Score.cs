using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public GameObject canvasend;
    public int scoreThreshold = 100;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        Ending();
    }

    private void Ending()
    {
        if (Score.score >= scoreThreshold)
        {
            canvasend.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
