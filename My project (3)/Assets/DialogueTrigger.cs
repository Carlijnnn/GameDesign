using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject Player;
    public bool triggered = false;

    public void TriggerDialogue () 
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

        private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && triggered == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            triggered = true;
        }
    }
}