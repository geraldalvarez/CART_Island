using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteract : MonoBehaviour
{
    public DialogueTrigger objectDialogue;
    public CanvasManager canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //need to limit the range
        canvas.GetComponent<CanvasManager>().OpenDialogueBox();
        objectDialogue.TriggerDialogue();
    }
}
