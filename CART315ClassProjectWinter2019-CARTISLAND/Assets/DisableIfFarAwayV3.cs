using UnityEngine;
using System.Collections;

public class DisableIfFarAwayV3 : MonoBehaviour
{

    // --------------------------------------------------
    // Variables:

    private GameObject itemActivatorObject;
    private ItemActivatorV3 activationScript;

    // --------------------------------------------------

    void Start()
    {
        itemActivatorObject = GameObject.Find("ItemActivatorObject");
        activationScript = itemActivatorObject.GetComponent<ItemActivatorV3>();

        StartCoroutine("AddToList");
    }

    IEnumerator AddToList()
    {
        yield return new WaitForSeconds(0.1f);

        activationScript.addList.Add(new ActivatorItemV3 { item = this.gameObject });
    }
}