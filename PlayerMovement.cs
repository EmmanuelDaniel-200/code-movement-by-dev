using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //from Emmanuel
    //make sure that rigidbidy2D gravityscale = 0
    public Rigidbody2D rb;
    public float speed;
    public float minY, maxY;
    Vector2 newPos;


    void Start(){

    }

    void FixedUpdate(){

       
        
        
        
            float dir = Input.GetAxis("Vertical");
            rb.velocity = Vector2.up * dir * speed;
    }

   
}
