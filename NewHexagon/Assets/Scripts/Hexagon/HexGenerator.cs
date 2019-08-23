using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGenerator : MonoBehaviour
{
    //public values
    public GameObject hexPrefab;
    public Transform hexTransform;
    public float spawnDelta = 1f;

    //private values
    private float nextSpawnTime = 0f;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Instantiate(hexPrefab, Vector3.zero , Quaternion.identity, hexTransform);
            nextSpawnTime = Time.time + 1 * spawnDelta;
        }
    }
}
