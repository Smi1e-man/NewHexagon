using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHex : MonoBehaviour
{
    //private values
    private float dir;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Start()
    {
        dir = Random.Range(0, 2);
    }

    private void Update()
    {
        if (dir > 1)
            transform.Rotate(Vector3.back, Time.deltaTime * 20f);
        else
            transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
    }
}
