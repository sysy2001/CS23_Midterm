using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour {

      public Rigidbody2D rb;
      public float moveSpeed = 5f;
      public Vector2 movement;
      public string NextLevel = "RestaurantScene";

      // Auto-load the RigidBody component into the variable:
      void Start(){
            rb = GetComponent<Rigidbody2D> ();
      }

      // Listen for player input to move the object:
      void FixedUpdate(){
            movement.x = Input.GetAxisRaw ("Horizontal");
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
      }

      // // Makes objects with the tag "tree" disappear on contact:
      // void OnCollisionEnter2D(Collision2D other){
      //       if (other.gameObject.tag == "RestaurantTag"){
      //             SceneManager.LoadScene (NextLevel);
      //       }
      // }
}