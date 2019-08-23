using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public values
    public Text textScore;

    /// <summary>
    /// Private Methods.
    /// </summary>
    void Update()
    {
        textScore.text = GameManager.G_score.ToString();
    }
}
