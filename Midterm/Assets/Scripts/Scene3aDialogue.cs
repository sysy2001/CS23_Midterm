using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
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
		//public GameObject Choice2c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		// public GameObject NextScene3Button;
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
		//Choice2c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		// NextScene3Button.SetActive(false);
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
                Char2name.text = "NPC";
                Char2speech.text = "Seasons greetings-. What an odd costume…?";
        }
		else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks! It's a hand-me-down.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "You know, not a lot of monster kids like superheroes.";
		}
		
		else if (primeInt == 8){
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
                Char2name.text = "NPC";
                Char2speech.text = "OH!.. Season's greetings!";
		}
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "I haven't seen you around in our neighborhood before. Where do you hail from?";
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
             Char2name.text = "NPC";
             Char2speech.text = "Because in movies superheros beat up on monsters.";
		}
		else if (primeInt==21){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "NPC";
             Char2speech.text = "But you would know that, if you were one.";
			primeInt = 39;
		}
		
		//response to choice 1b
		else if (primeInt==30){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "NPC";
             Char2speech.text = "Still, I don’t know a lot of monster parents who let their kids around superhero stuff.";
		}
		else if (primeInt==31){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "NPC";
             Char2speech.text = "Superheros are more of a human thing.";
		}
		else if (primeInt==32){
			 Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "NPC";
             Char2speech.text = "Unless you're a human.";
			primeInt = 39;
		}
		
		
		
	// after choice 1 is complete	
       else if (primeInt == 40){
                Char1name.text = "You";
                Char1speech.text = "Uhhhh...";
                Char2name.text = "";
                Char2speech.text = "";
	   }
	   else if (primeInt == 41){
				ArtChar1b.SetActive(false);
		   		ArtChar1a.SetActive(true);
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "Silly little human";
		}
	   else if (primeInt == 42){
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "I've been giving out the treats all night,";
		}
			   else if (primeInt == 43){
				ArtChar1a.SetActive(false);
		   		ArtChar1c.SetActive(true);
	            Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "but it seems a treat of my own has wandered onto my doorstep.";
			   }
			    else if (primeInt == 44){
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
		 else if (primeInt == 350){
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
       else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "You must be Dolores' little nibbling!";
	   }
	   	else if (primeInt == 301){
                Char1name.text = "YOU";
                Char1speech.text = "Yup, totally good ol Dolores, she's definitely my aunt, totally not a lie.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
                Char2speech.text = "Here you go kid, a nice piece of candy! And say hi to your aunt for me, would you?";
		}
		else if (primeInt == 303){
                Char1name.text = "YOU";
                Char1speech.text = "Suuurrreee…. Thanks";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt=349;
        }




		else if (primeInt == 400){
				ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
				Char2speech.text = "... Oh uh, alright.";
	   }
	   	else if (primeInt == 401){
                Char1name.text = "YOU";
                Char1speech.text = "Um, can I have some candy now?";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 402){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "NPC";
				Char2speech.text = "Sure, Here's some candy. Don't lose it in the swamps, I guess.";
				primeInt=349;
	   }
		
		
       // else if (primeInt == 500){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "SIBLING";
				// Char2speech.text = "Sure, twerp. Just not in front of my friends.";
				// primeInt=49;
	   // }

		
	// never delete the bracket below here. it en ds the next() function!:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh? Why is that?";
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
                Char1speech.text = "Oh, I know, but I am a special little monster! My mom tells me so!";
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
                Char1speech.text = "I'm visiting family for holiday.";
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
                Char1speech.text = "I hail from the deep and dark swamps of Transylvania.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
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
		// public void SceneChange3(){
                // SceneManager.LoadScene("Scene3c");
        // }
}