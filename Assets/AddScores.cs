using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScores : MonoBehaviour
{
    public AudioSource audioPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        audioPlayer.Play();

    }
}
