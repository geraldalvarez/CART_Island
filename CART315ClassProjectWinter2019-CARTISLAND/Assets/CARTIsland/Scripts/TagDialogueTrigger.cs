using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDialogueTrigger : MonoBehaviour
{
    public string tagTrigger = "";
    private bool pickedUp = false;
    public DialogueTrigger objectDialogue;
    public CanvasManager canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if the tag is equal to diploma
        if (gameObject.tag == tagTrigger && !pickedUp)
        {
            pickedUp = true;
            canvas.GetComponent<CanvasManager>().OpenDialogueBox();
            objectDialogue.TriggerDialogue();
        }
    }
}



