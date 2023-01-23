using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float yMin, yMax;
    public float spawnRate = 1;

    private void Start()
    {
        InvokeRepeating("CreatePipes", 0, spawnRate);
    }

    private void CreatePipes()
    {
        Instantiate(prefab, new Vector2(transform.position.x, Random.Range(yMin, yMax)), Quaternion.identity);
    }
}
