
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_ItemSlot : MonoBehaviour, IDropHandler {

       public GameObject item1;
       public GameObject item2;
       public GameObject item3;
       public GameObject item4;
       public GameObject item5;
       public GameObject item6;


       void Start(){
              item1.SetActive(false);
              item2.SetActive(false);
              item3.SetActive(false);
              item4.SetActive(false);
              item5.SetActive(false);
              item6.SetActive(false);
       }



        public void OnDrop(PointerEventData eventData){
              if (eventData.pointerDrag != null){
                     Vector2 slotCenter = GetComponent<RectTransform>().anchoredPosition;
                     eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = slotCenter;
              }
       }
}
