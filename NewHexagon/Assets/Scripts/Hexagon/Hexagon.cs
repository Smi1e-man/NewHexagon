using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    //public values
    public Rigidbody2D hex;
    public float speed = 3f;
    public float scaleDelta = 10f;

    /// <summary>
    /// Private Methods.
    /// </summary>
	private void Awake()
	{
        hex = GetComponent<Rigidbody2D>();
	}

    private void Start()
    {
        hex.rotation = Random.Range(0, 6) * 60f;
        transform.localScale = Vector3.one * scaleDelta;
    }

    private void Update()
    {
        transform.localScale -= Vector3.one * speed * Time.deltaTime;
        if (transform.localScale.x <= 0.05f)
        {
			Destroy(gameObject);
            GameManager.G_score++;         
        }
    }
}
