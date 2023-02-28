
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterRestaurant : MonoBehaviour{

      public string NextLevel = "Restaurant2";

      public void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Car"){
                  SceneManager.LoadScene (NextLevel);
            }
      }

}