using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public Canvas canvas;

    public void CloseDialogueBox()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }

    public void OpenDialogueBox()
    {
        canvas.GetComponent<Canvas>().enabled = true;
    }
}
