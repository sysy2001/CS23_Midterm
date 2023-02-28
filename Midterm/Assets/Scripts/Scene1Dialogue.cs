using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject FrameSuper;
		public GameObject FrameGhost;
		public GameObject FrameWolf;
		public GameObject Frame2Super;
		public GameObject Frame2Ghost;
		public GameObject Frame2Wolf;
		
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
		public GameObject Choice2c;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		FrameSuper.SetActive(false);
		FrameGhost.SetActive(false);
		FrameWolf.SetActive(false);
		Frame2Super.SetActive(false);
		Frame2Ghost.SetActive(false);
		Frame2Wolf.SetActive(false);
		
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
		Choice2c.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Hey squirt, get your costume on, we're leaving soon.";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "What are you talking about, I thought mom was taking me trick or treating?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Mom had to go and get more candy to hand out.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Which means she dumped you on me.";
        }
		
		else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(But I want mom...)";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		//response to choice 1a
		else if (primeInt==20){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "No need for an attitude, I didn't choose this either";
			primeInt = 39;
		}
		
		
		//response to choice 1b
		else if (primeInt==30){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "Ugh, you're getting on my last nerve!";
		}
		else if (primeInt==31){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "SIBLING";
             Char2speech.text = "She told me to take you! That's it.";
			primeInt = 39;
		}
		
		
		
	// after choice 1 is complete	
       else if (primeInt == 40){
		   ArtBG1.SetActive(false);
		   ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = " Mom left my old costumes in your closet.";
        }
       else if (primeInt ==41){
                Char1name.text = "YOU";
                Char1speech.text = "WOAH!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Stop wasting time and go pick one.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
				Choice2c.SetActive(true); // function Choice2cFunct()
        }
		
	// after choice 2 is complete		
		 else if (primeInt == 50){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Alright already. I’m gonna be late to my plans. Let’s go!";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
                Char2speech.text = "Wait 'til you hit puberty, atomic face.";
				primeInt=49;
        }

		else if (primeInt == 400){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
				Char2speech.text = "Oh, wow. SO scary.";
	   }
	   		else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
				Char2speech.text = "Cut it out, twerp.";
				primeInt=49;
	   }
		
		
       else if (primeInt == 500){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SIBLING";
				Char2speech.text = "Sure, twerp. Just not in front of my friends.";
				primeInt=49;
	   }

		
	// never delete the bracket below here. it en ds the next() function!:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Fine, let me just get my costume on.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No way, I want mom to take me.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice2aFunct(){
                FrameSuper.SetActive(true);
				Frame2Super.SetActive(true);
				GameHandler.isSuper = true;
				Char1name.text = "YOU";
                Char1speech.text = "I’m gonna be super! Like captain atomic face!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
			FrameGhost.SetActive(true);
			Frame2Ghost.SetActive(true);
				GameHandler.isGhost = true;
                Char1name.text = "YOU";
                Char1speech.text = "Boo! Were you scared?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2cFunct(){
			FrameWolf.SetActive(true);
			Frame2Wolf.SetActive(true);
				GameHandler.isWolf = true;
                Char1name.text = "YOU";
                Char1speech.text = "What does a wolf say? Woof?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 499;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
        }
        //public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        //}
}