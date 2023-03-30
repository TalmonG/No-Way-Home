using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShow : MonoBehaviour
{  
    
    public Animator myAnimationController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("Text", true);
        }
    }

    void OnTriggerExit (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            
        }
    }
}
