using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich_slot : MonoBehaviour{
	
	public int slotID = 1;
	public string foodFilled;
	
	//ingredient image slots
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;
			
	//flashing on trigger enter:
	public GameObject slotBG;
	public Color flashColor;
	public Color startColor;
			
			
    void Start(){
		//make all ingredients invisible
		item1.SetActive(false);
        item2.SetActive(false);
		item3.SetActive(false);
		item4.SetActive(false);
		item5.SetActive(false);
		item6.SetActive(false);
		
		startColor = slotBG.GetComponent<SpriteRenderer>().color;
		//flashColor = new Color(2.3f, 2.3f, 1.1f, 1f);
    }

    void Update(){
		//make the current ingredient visible
        if (foodFilled == "bunTop"){item1.SetActive(true); slotBG.SetActive(false);}
		else if (foodFilled == "lettuce") {item2.SetActive(true); slotBG.SetActive(false);}
		else if (foodFilled == "tomato") {item3.SetActive(true); slotBG.SetActive(false);}
		else if (foodFilled == "pickles") {item4.SetActive(true); slotBG.SetActive(false);}
		else if (foodFilled == "meat") {item5.SetActive(true); slotBG.SetActive(false);}
		else if (foodFilled == "bunBot") {item6.SetActive(true); slotBG.SetActive(false);}
    }
	
	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "SandwichFood"){
			slotBG.GetComponent<SpriteRenderer>().color = flashColor;
		}
	}
	
	public void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.tag == "SandwichFood"){
			slotBG.GetComponent<SpriteRenderer>().color = startColor;
		}
	}
	
	public void RefreshSlot(){
		item1.SetActive(false);
        item2.SetActive(false);
		item3.SetActive(false);
		item4.SetActive(false);
		item5.SetActive(false);
		item6.SetActive(false);
		slotBG.SetActive(true);
		foodFilled = "";
		slotBG.GetComponent<SpriteRenderer>().color = startColor;
	}
	
}
