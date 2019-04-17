using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    public string newTag = "";

    //function that change the tag
    public void ChangeTheTag()
    {
        gameObject.tag = newTag;
    }
}
