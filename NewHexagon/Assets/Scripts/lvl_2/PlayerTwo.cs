using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwo : MonoBehaviour
{
    //private values
    private Rigidbody2D rb;
    private Vector2 heightDelta = new Vector2(0f, 2.5f);

    /// <summary>
    /// Private Methods.
    /// </summary>
	private void Awake()
	{
        rb = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        if (rb.velocity.y > 2.5f)
        {
            rb.velocity = heightDelta;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.G_score = 0;
    }
}
