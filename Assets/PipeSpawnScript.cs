using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
            timer = 0;
        }
    }
}
