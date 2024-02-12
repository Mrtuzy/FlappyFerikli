using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] pipes;
    
    public float heigtRange = 10;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0;
        }
  
        
    }
    void Spawn()
    {
        
        float maxHeight = transform.position.y + heigtRange;
        float minHeight = transform.position.y - heigtRange;
        Instantiate(pipes[Random.Range(0,pipes.Length)], new Vector3(transform.position.x, Random.Range(maxHeight, minHeight), 0), transform.rotation);
    }
}
