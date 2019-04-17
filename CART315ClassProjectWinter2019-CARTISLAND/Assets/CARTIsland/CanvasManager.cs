using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDialogueBox()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }

    public void OpenDialogueBox()
    {
        canvas.GetComponent<Canvas>().enabled = true;
    }
}
