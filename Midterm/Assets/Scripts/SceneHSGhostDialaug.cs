using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SceneHSGhostDialaug : MonoBehaviour {
        public int primeInt = 1;      
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar1b;
        public GameObject ArtBG1;
        public GameObject NextScene1Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
        private bool allowSpace = true;

void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar1b.SetActive(false);
        ArtBG1.SetActive(true);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Ghost";
                Char1speech.text = "Oh a human!";
        }
       else if (primeInt ==3){
		      ArtChar1.SetActive(false);
		      ArtChar1b.SetActive(true);
                Char1name.text = "Ghost";
                Char1speech.text = "Splendid, you’ll go nicely with my dinner plans.";
        }
        // public void SceneChange1(){
               // SceneManager.LoadScene("Scene2a");
        // }
}
}