using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //private values
    private Vector3 rotateDelta = new Vector3(0, 0, 60);

    /// <summary>
    /// Private Methods.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.eulerAngles += rotateDelta;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.eulerAngles -= rotateDelta;
        }
    }
}
