using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;





public class PlayerJump : MonoBehaviour{
 public Rigidbody2D rb;
 public float jumpAmount = 10;
 public float gravityScale = 10;
 public float fallingGravityScale = 40;
        
 void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
     {
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
     }


      if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
      else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
    
 
    
    
   
    
}
