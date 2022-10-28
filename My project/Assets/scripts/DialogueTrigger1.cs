using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue1 dialogue;
    public GameObject Player;
    public bool triggered = false;

    public void TriggerDialogue1 () 
    {
        FindObjectOfType<DialogueManager1>().StartDialogue1(dialogue);
    }

        private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && triggered == false)
        {
            FindObjectOfType<DialogueManager1>().StartDialogue1(dialogue);
            triggered = true;
        }
    }
}