using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    public LogicScript logic;
    public GameObject text;
 
    void Start()
    {
     logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();  
    }

    
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.IncreaseScore();
            text.SetActive(false);
        }
        
    }
  
}
