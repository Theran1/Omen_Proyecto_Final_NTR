using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, Interface_Interactable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public NPCConversation RecievedDialogue;

    //---------------------------------------
    int reputationLibra;
    private Inventory inventory;

    private void Awake()
    {
        inventory= GameObject.Find("HumanMale_Character_FREE").GetComponent<Inventory>();
    }

    public bool Interact(Interactor interactor)
    {
        
        //-----------DONT TOUCH------------
        ConversationManager.Instance.StartConversation(RecievedDialogue);
        //-------------------------------------------

        if(RecievedDialogue.name == "HungryDialogue")
        {
            if (inventory.HasBread == true)
            {
                ConversationManager.Instance.SetBool("HasBread", true);
            }
            else
            {
                ConversationManager.Instance.SetBool("HasBread", false);
            }
            reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");

            /*if
            ConversationManager.Instance.(nombre de la accion seleccionada) = "goodforlibra";
            ConversationManager.Instance.SetInt("reputationLibra", reputationLibra + 20);
            else
            ConversationManager.Instance.SetInt("reputationLibra", reputationLibra - 20);
            */
        }

        //reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");



        return true;
    }

    private void Update()
    {

        reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");
        Debug.Log("libraRep: " + reputationLibra);
    }

}
