using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    public GameObject LevelController;
    public float velocity=1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           rb.velocity=Vector2.up*velocity;  
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       
        { 
            LevelController.GetComponent<LevelController>().GameOver();     
        }
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="score")
        {
            FindObjectOfType<ScoreManager>().score += 1;
        }
    }
}
