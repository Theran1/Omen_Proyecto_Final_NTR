using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, Interface_Interactable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public NPCConversation IntroDialogue;
    public bool Interact(Interactor interactor)
    {
        ConversationManager.Instance.StartConversation(IntroDialogue);
        //Debug.Log(message: "npc dialogue here");
        return true;
    }

}
