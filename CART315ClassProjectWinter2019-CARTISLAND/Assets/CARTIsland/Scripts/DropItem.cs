using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject grabPoint;
    private Pickupper pickupper;
    private GameObject heldObject;
    private ChangeTag changeTag;

    // Start is called before the first frame update
    void Start()
    {
        pickupper = GetComponent<Pickupper>();
        
    }

    public void DropHeldObject()
    {
        if (pickupper.IsHoldingObject())
        {
            //set the child gameobject
            heldObject = grabPoint.gameObject.transform.GetChild(0).gameObject;
            //gettting the component
            changeTag = grabPoint.GetComponentInChildren<ChangeTag>();
            //changing the tag when thrown
            changeTag.ChangeTheTag();

            //fix the gravity an
            heldObject.GetComponent<Rigidbody>().useGravity = true;
            heldObject.GetComponent<Rigidbody>().isKinematic = false;
            heldObject.GetComponent<BoxCollider>().isTrigger = false;

            //detach the child
            grabPoint.transform.DetachChildren();

            //add force
            heldObject.GetComponent<Rigidbody>().AddForce(grabPoint.gameObject.transform.forward * 300); 

        }
        else
        {
            Debug.Log("Not holding it");
        }
    }
}
