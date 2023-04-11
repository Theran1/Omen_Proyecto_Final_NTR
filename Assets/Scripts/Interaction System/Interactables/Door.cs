using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Interface_Interactable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    //public NPCConversation correspondingConversation;
    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();
        if (inventory == null) return false;
        if (inventory.HasKey)
        {
            Debug.Log(message: "Open door action here");
            return true;
        }

        Debug.Log(message: "No Key Popup Here");
        return false;

    }
}
