using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed = 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        if (transform.position.x < -30)
        {
            Destroy(gameObject);
            Debug.Log("yok edildi");
        }
    }
}
