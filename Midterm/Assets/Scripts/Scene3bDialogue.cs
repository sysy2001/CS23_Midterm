using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
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
       public GameObject ArtChar1c;
        public GameObject ArtBG1;
		//public GameObject ArtBG2;
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
		public GameObject Choice3a;
		public GameObject Choice3b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		
        ArtBG1.SetActive(true);
		//ArtBG2.SetActive(false);
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
		Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);

    if (GameHandler.isSuper == true){
		FrameSuper.SetActive(true);
		Frame2Super.SetActive(true);
	}
	if (GameHandler.isGhost == true){
		FrameGhost.SetActive(true);
		Frame2Ghost.SetActive(true);
	}
	if (GameHandler.isWolf == true){
		FrameWolf.SetActive(true);
		Frame2Wolf.SetActive(true);
	}
	
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
			if (GameHandler.isSuper == true){
			primeInt = 3;
			}
			if (GameHandler.isGhost == true){
			primeInt = 99;
			}
			if (GameHandler.isWolf == true){
			primeInt = 99;
			}
        }
		
		// SUPER ROUTE
       else if (primeInt == 4){
		        ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Trick or Treat!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
		   		ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
                Char2speech.text = "Hello little one, what an odd costume.";
        }
		else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
                Char2speech.text = "What are you supposed to be?";
		}
		
		else if (primeInt == 7){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		
		
		
		
		
		//if monster
			else if (primeInt == 100){
				ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Trick or treat!";
                Char2name.text = "";
                Char2speech.text = "";
		}
			else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost";
                Char2speech.text = "Hello dear, well aren't you a cutie-pie!";
		}
		else if (primeInt == 102){
				ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost";
                Char2speech.text = "Haven't seen you around here before. Where are your parents, dear? Do you not have any, are you alone?";
		}
				else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice1aFunct()
                Choice2b.SetActive(true); // function Choice1bFunct()
        }
		
		
		
		
		//response to choice 1a
		else if (primeInt==20){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "GHOST";
             Char2speech.text = "Why would you want to be something like that?";
		}
		else if (primeInt==21){
			 Char1name.text = "YOU";
             Char1speech.text = "Because they're cool.";
             Char2name.text = "";
             Char2speech.text = "";
		}
		else if (primeInt==22){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "GHOST";
             Char2speech.text = "The only people who think superheroes are cool are- gasp!";
			primeInt = 39;
		}
		
		//response to choice 1b
		else if (primeInt==30){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Ghost";
             Char2speech.text = ".";
		}
		else if (primeInt==31){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Ghost";
             Char2speech.text = "..";
		}
		else if (primeInt==32){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Ghost";
             Char2speech.text = "...";
			primeInt = 39;
		}
		
		//Response to choice 2a
			else if (primeInt==300){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "GHOST";
             Char2speech.text = "Dear, I know it can be traumatic. But you can be truthful with me.";
		}
		else if (primeInt==301){
			 Char1name.text = "YOU";
             Char1speech.text = "No I actually have parents.";
             Char2name.text = "";
             Char2speech.text = "";
		}
		else if (primeInt==302){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "GHOST";
             Char2speech.text = "Dear its ok, you don't have to lie";
		}
		else if (primeInt==303){
			 Char1name.text = "YOU";
             Char1speech.text = "No, really I have a family and they’re waiting for me.";
             Char2name.text = "";
             Char2speech.text = "";
		}
		else if (primeInt==304){
			 Char1name.text = "YOU";
             Char1speech.text = "Can I just have the candy and get back to them?";
             Char2name.text = "";
             Char2speech.text = "";
			primeInt = 349;
		}
			
			//Response to choice 2b
			else if (primeInt==400){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "GHOST";
             Char2speech.text = "Oh deary me! How upsetting!";
		}
		else if (primeInt==401){
			 Char1name.text = "YOU";
             Char1speech.text = "Yeah it really is. Can I have candy please?";
             Char2name.text = "";
             Char2speech.text = "";
			primeInt = 349;
		}
		
		
	// after choice 1 is complete	
       else if (primeInt == 40){
		   		ArtChar1b.SetActive(false);
		   		ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
                Char2speech.text = "Oh you're a human!";
	   }
	   else if (primeInt == 41){
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
                Char2speech.text = "Only a human would say that!";
		}
			   else if (primeInt == 42){
				ArtChar1a.SetActive(false);
		   		ArtChar1c.SetActive(true);
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
                Char2speech.text = "Splendid, you’ll go nicely with my dinner plans.";
			   }
			    else if (primeInt == 43){
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
				ArtChar1c.SetActive(false);
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				// NextScene2Button.SetActive(true);
				// NextScene3Button.SetActive(true);
        }
       // else if (primeInt ==41){
                // Char1name.text = "YOU";
                // Char1speech.text = "WOAH!";
                // Char2name.text = "";
                // Char2speech.text = "";
				// primeInt = 49;
        // }
       // else if (primeInt == 42){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "SIBLING";
                // Char2speech.text = "Stop wasting time and go pick one.";
                //Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // Choice2a.SetActive(true); // function Choice2aFunct()
                // Choice2b.SetActive(true); // function Choice2bFunct()
				// Choice2c.SetActive(true); // function Choice2cFunct()
        // }
		
	//after choice 2 is complete	
// button to go back to street	
		 else if (primeInt == 700){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
		 }
						
						
			// if (GameHandler.isSuper == true){
			// Char2speech.text = "Ok, Superface. Try not get to get kidnapped.";
			// }
			// if (GameHandler.isGhost == true){
			// Char2speech.text = "Alright, sheets-a-lot. See you when I see you.";
			// }
			// if (GameHandler.isWolf == true){
			// Char2speech.text = "Alright, fuzzy. Don't forget-- I get half your candy.";
			// }
		// }
		 
       // else if (primeInt ==51){
		   // ArtChar1b.SetActive(false);
                // Char1name.text = "YOU";
                // Char1speech.text = "Huh. Which house should I try first?";
                // Char2name.text = "";
                // Char2speech.text = "";
		 
				// Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // NextScene1Button.SetActive(true);
				// NextScene2Button.SetActive(true);
				// NextScene3Button.SetActive(true);
        // }

// ENCOUNTER AFTER CHOICE #2



// After monster talk choices
		else if (primeInt == 350){
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
				Char2speech.text = "Of course sweetheart! Here you go";
	  		if (GameHandler.isGhost == true){
			primeInt = 899;
			}
			if (GameHandler.isWolf == true){
			primeInt = 699;
			}
		}
		//ghost route
			else if (primeInt == 900){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
				Char2speech.text = "But if you’d like, I have something even better than candy inside.";
		}
			else if (primeInt == 901){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GHOST";
				Char2speech.text = "If you would just follow me and I can show you.";
		}
			else if (primeInt == 902){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
		     // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice1aFunct()
                Choice3b.SetActive(true); // function Choice1bFunct()
			}
		// choice 3a response
       else if (primeInt == 1100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost";
				Char2speech.text = "Wait, come back!";
	   }
	        else if (primeInt == 1101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost";
				Char2speech.text = "bye lady!";
	   }
	     else if (primeInt == 1102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
	   }


// after 3b
		       else if (primeInt == 1200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost";
				Char2speech.text = "You’ll see, just come this way.";
	   }
	     else if (primeInt == 1201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "";
				ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(false);
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene3Button.SetActive(true);
	   }

	// never delete the bracket below here. it en ds the next() function!:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm a superhero, cant you tell?";
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
                Char1speech.text = "ur mom";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice2aFunct(){
				Char1name.text = "YOU";
                Char1speech.text = "I have parents. My sibling is trick or treating with me, I'm not alone.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "My parents abandoned me.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice3aFunct(){
				Choice3a.SetActive(false); // function Choice1aFunct()
				Choice3b.SetActive(false); // function Choice1aFunct()
				Char1name.text = "YOU";
                Char1speech.text = "No thanks, I'm not comfy going into random people's homes.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 1099;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct(){
				Choice3a.SetActive(false); // function Choice1aFunct()
				Choice3b.SetActive(false); // function Choice1aFunct()
                Char1name.text = "YOU";
                Char1speech.text = "Ok…. Sure what is it?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 1199;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        // public void Choice2cFunct(){
			// FrameWolf.SetActive(true);
			// Frame2Wolf.SetActive(true);
				// GameHandler.isWolf = true;
                // Char1name.text = "YOU";
                // Char1speech.text = "What does a wolf say? Woof?";
                // Char2name.text = "";
                // Char2speech.text = "";
                // primeInt = 499;
                // Choice2a.SetActive(false);
                // Choice2b.SetActive(false);
				// Choice2c.SetActive(false);
                // nextButton.SetActive(true);
                // allowSpace = true;
        // }
		
		

        public void SceneChange1(){
               SceneManager.LoadScene("DEATH");
        }
       public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("Scene4a");
        }
}

//add story choice 3a and 3b. ghost route is 900. change her pose, finiah ghost route, figure out the pause thing