
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExitSimple : MonoBehaviour{

      public string NextLevel = "RestaurantScene";

      public void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Car"){
                  SceneManager.LoadScene (NextLevel);
            }
      }

}