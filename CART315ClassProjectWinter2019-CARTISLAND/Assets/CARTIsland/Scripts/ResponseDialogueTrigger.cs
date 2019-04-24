using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseDialogueTrigger : MonoBehaviour
{

    public GameObject objectSubject;

    //private DialogueTrigger objectDialogue;
    //private CanvasManager canvas;
    //private ClickInteract clickInteractScript;

    private Restore restoreScript;
    private bool dialogueTriggered = false; 

    // Start is called before the first frame update
    void Start()
    {
        restoreScript = GetComponent<Restore>();
  
    }

    // Update is called once per frame
    void Update()
    {
        //check if the challenge is done and dialogue trigger is false
        if(!dialogueTriggered && restoreScript.isChallengeDone())
        {
            dialogueTriggered = true;
            objectSubject.GetComponent<ClickInteract>().setDialogueIndex(1);


            //open the dialogue box
            objectSubject.GetComponent<CanvasManager>().OpenDialogueBox();
            objectSubject.GetComponent<ClickInteract>().getDialogue().TriggerDialogue();

        }
    }
}
