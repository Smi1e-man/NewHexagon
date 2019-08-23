using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCentreScore : MonoBehaviour
{
    //private values
    private int scoreValue;
    private Vector3 scaleValue;

    //public values
    public float deltaScale = 0.1f;
    public float bigScale = 1.24f;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Start()
    {
        scoreValue = GameManager.G_score;
        scaleValue = transform.localScale;
    }

    private void Update()
    {
        if (scoreValue < GameManager.G_score)
        {
            scoreValue = GameManager.G_score;
            Scailing();
        }
        if (transform.localScale.x > scaleValue.x)
        {
            transform.localScale -= Vector3.one * deltaScale;
        }
    }

    private void Scailing()
    {
        transform.localScale *= bigScale;
    }
}
