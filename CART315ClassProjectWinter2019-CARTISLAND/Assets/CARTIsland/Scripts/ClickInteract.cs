using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteract : MonoBehaviour
{
    public DialogueTrigger[] objectDialogue;
    public CanvasManager canvas;

    private int currentDialogueIndex = 0;

    private void OnMouseDown()
    {
        //need to limit the range
        canvas.GetComponent<CanvasManager>().OpenDialogueBox();
        objectDialogue[currentDialogueIndex].TriggerDialogue();
    }

    public void setDialogueIndex(int index)
    {
        currentDialogueIndex = index;
    }

    public DialogueTrigger getDialogue()
    {
        return objectDialogue[currentDialogueIndex];
    }
}
