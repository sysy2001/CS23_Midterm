using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour{

      public string NextScene = "EndScene";

      public void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Car"){
                  SceneManager.LoadScene (NextScene);
            }
      }

}