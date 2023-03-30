using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractText : MonoBehaviour
{   
     private GameObject PromptE;
     void Start() 
     {
         PromptE = GameObject.Find("PromptE");
         PromptE.gameObject.SetActive(false);
     }
     void OnTriggerEnter (Collider other) 
     {
         if (other.CompareTag ("Player")) 
         {
             PromptE.gameObject.SetActive(true);
         }
     }
 
     void OnTriggerExit (Collider other) 
     {
         if (other.CompareTag ("Player")) 
         {
             PromptE.gameObject.SetActive(false);
         }
     }
}
