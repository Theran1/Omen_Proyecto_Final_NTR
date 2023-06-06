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

    float reputationAries;
    float reputationTaurus;
    float reputationGemini;
    float reputationCancer;
    float reputationLeo;
    float reputationVirgo;
    float reputationLibra;
    float reputationScorp;
    float reputationSagi;
    float reputationCapri;
    float reputationAcua;
    float reputationPsicis;

    private SysHandler sysHandler;
    private Inventory inventory;

    private void Awake()
    {
        sysHandler = GameObject.Find("Debug").GetComponentInChildren<SysHandler>();
        inventory= GameObject.Find("HumanMale_Character_FREE").GetComponent<Inventory>();
    }

    private void Start()
    {
        reputationAries = sysHandler.repAries;
        reputationTaurus = sysHandler.repTaurus;
        reputationGemini = sysHandler.repGemini;
        reputationCancer = sysHandler.repCancer;
        reputationVirgo = sysHandler.repVirgo;
        reputationLibra = sysHandler.repLibra;
        reputationScorp = sysHandler.repScorpio;
        reputationSagi = sysHandler.repSagi;
        reputationCapri = sysHandler.repCapri;
        reputationAcua = sysHandler.repAqua;
        reputationPsicis = sysHandler.repPiscis;
    }

    public bool Interact(Interactor interactor)
    {
        
        //-----------DONT TOUCH------------
        ConversationManager.Instance.StartConversation(RecievedDialogue);
        //-------------------------------------------

        if(RecievedDialogue.name == "HungryDialogue")
        {
            if (inventory.HasPotato == true)
            {
                ConversationManager.Instance.SetBool("HasPotato", true);
            }
            else
            {
                ConversationManager.Instance.SetBool("HasPotato", false);
            }
           // reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");

            /*if
            ConversationManager.Instance.(nombre de la accion seleccionada) = "goodforlibra";
            ConversationManager.Instance.SetInt("reputationLibra", reputationLibra + 20);
            else
            ConversationManager.Instance.SetInt("reputationLibra", reputationLibra - 20);
            */
            
        }
        if (RecievedDialogue.name == "Potato")
        {
            if (ConversationManager.Instance.GetBool("PickedUpPotato") == true)
            {
                inventory.HasPotato = true;
            }
            else { inventory.HasPotato = false;}
        }

            //reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");



            return true;
    }

    private void Update()
    {
        UpdateReps();
        //reputationLibra = ConversationManager.Instance.GetInt("reputationLibra");
        //Debug.Log("libraRep: " + reputationLibra);
    }

    private void UpdateReps()
    {
        reputationAries = sysHandler.repAries;
        reputationTaurus = sysHandler.repTaurus;
        reputationGemini = sysHandler.repGemini;
        reputationCancer = sysHandler.repCancer;
        reputationVirgo = sysHandler.repVirgo;
        reputationLibra = sysHandler.repLibra;
        reputationScorp = sysHandler.repScorpio;
        reputationSagi = sysHandler.repSagi;
        reputationCapri = sysHandler.repCapri;
        reputationAcua = sysHandler.repAqua;
        reputationPsicis = sysHandler.repPiscis;
    }

}
