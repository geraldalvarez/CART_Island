using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInteract : MonoBehaviour
{
    public DialogueTrigger[] objectDialogue;
    public CanvasManager canvas;

    private AudioSource audioSource;
    public AudioClip audioClip;
    public float volume = 0f;

    private int currentDialogueIndex = 0;

    private void Start()
    {
        //check if there is an audio source
        if (GetComponent<AudioSource>() == null)
        {
            //add an AudioSource
            audioSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        }
    }

    private void OnMouseDown()
    {
        //play the sound fx        
        audioSource.PlayOneShot(audioClip, volume);

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
