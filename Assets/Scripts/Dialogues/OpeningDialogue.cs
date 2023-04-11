using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class OpeningDialogue : MonoBehaviour
{
    public NPCConversation Introduction;
    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(Introduction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
