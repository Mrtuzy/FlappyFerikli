using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FerikliControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody;
    public float dashForce = 10;
    public LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && logic.IsAlive == true && logic.IsStart == true)
        {
            rigidbody.velocity = Vector2.up * dashForce;
        }
        if ((transform.position.y < -15.5 || transform.position.y > 15) && logic.IsWin == false)
        {
            logic.Gameover();
        }
        if (logic.playerScore == 100)
        {
            logic.Win();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic.IsWin == false)
        {
            logic.Gameover();
        }
       
    }
}
