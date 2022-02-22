using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    // public static int score;
    public int score;
   
    void Start()
    {
        
    }


    void Update()
    {
        
        transform.Translate(0,bulletSpeed,0);
      
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        print("Score = " + score);
        Destroy(collision.gameObject);
                  


    }

}
