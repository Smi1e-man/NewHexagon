using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NeedScore : MonoBehaviour
{
    //public values
    public Text needScr;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Update()
    {
        needScr.text = GameManager.G_score.ToString() + " / " + GameManager.G_result.ToString();
        if (GameManager.G_score == GameManager.G_result)
        {
            GameManager.G_score = 0;
            GameManager.G_result *= 2;
            if (SceneManager.GetActiveScene().buildIndex < 2)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
