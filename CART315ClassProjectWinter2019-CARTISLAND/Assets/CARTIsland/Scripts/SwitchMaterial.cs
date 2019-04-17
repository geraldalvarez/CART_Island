using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{
    public Material[] materialArray;

    public void ChangeMaterial(int index)
    {
        gameObject.GetComponent<Renderer>().material = materialArray[index];

    }
}
