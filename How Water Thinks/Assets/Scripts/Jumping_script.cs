/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping_script : MonoBehaviour {

     public float jumpHeight;
     private bool isJumping = false; // this doesn't need to be public
     private Rigidbody2D rigidbody;
 
     private void Update ()
     {
         if (Input.GetKeyDown (KeyCode.Space) && !isJumping) // both conditions can be in the same branch
         { 
             rigidbody.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
             isJumping = true;
          }
      }
 
     private void OnCollisionEnter2D (Collision col)
     {
         if (col.gameObject.tag == "ground") // GameObject is a type, gameObject is the property
         {
             isJumping = false;
         }
     }
  } */


using UnityEngine;
using System.Collections;
     

     public class Jumping_script : MonoBehaviour {
      //   public float Speed = 5.0f;
        // public Vector3 jump;
         //public float jumpForce = 2.0f;
     
     public float jumpHeight = 2f; 
     public static bool isJumping = false;
        // public bool isGrounded = true;
         Rigidbody rb;
         void Start(){
             rb = transform.GetComponent<Rigidbody>();
           //  jump = new Vector3(0.0f, 2.0f, 0.0f);
         }
     
         void Update(){
            if (Input.GetButtonDown("Jump") && (isJumping == false)) 
{
    isJumping = true;
   gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
}
         }

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.tag == "ground")
    {
       isJumping = false;
    }
}

     }
     