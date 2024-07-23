using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Conversation_Starter : MonoBehaviour
{
    [SerializeField] private NPCConversation Myconversation;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(Myconversation);
            }
          

        }
    }
}
