using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemActivatorV3 : MonoBehaviour
{

    // --------------------------------------------------
    // Variables:

    [SerializeField]
    private int distanceFromPlayer;

    private GameObject player;

    private List<ActivatorItemV3> activatorItems;

    public List<ActivatorItemV3> addList;

    // --------------------------------------------------

    void Start()
    {
        player = GameObject.Find("Player");
        activatorItems = new List<ActivatorItemV3>();
        addList = new List<ActivatorItemV3>();

        AddToList();
    }

    void AddToList()
    {
        if (addList.Count > 0)
        {
            foreach (ActivatorItemV3 item in addList)
            {
                if (item.item != null)
                {
                    activatorItems.Add(item);
                }
            }

            addList.Clear();
        }

        StartCoroutine("CheckActivation");
    }

    IEnumerator CheckActivation()
    {
        List<ActivatorItemV3> removeList = new List<ActivatorItemV3>();

        if (activatorItems.Count > 0)
        {
            foreach (ActivatorItemV3 item in activatorItems)
            {
                if (Vector3.Distance(player.transform.position, item.item.transform.position) > distanceFromPlayer)
                {
                    if (item.item == null)
                    {
                        removeList.Add(item);
                    }
                    else
                    {
                        item.item.SetActive(false);
                    }
                }
                else
                {
                    if (item.item == null)
                    {
                        removeList.Add(item);
                    }
                    else
                    {
                        item.item.SetActive(true);
                    }
                }

                yield return new WaitForSeconds(0.01f);
            }
        }

        yield return new WaitForSeconds(0.01f);

        if (removeList.Count > 0)
        {
            foreach (ActivatorItemV3 item in removeList)
            {
                activatorItems.Remove(item);
            }
        }

        yield return new WaitForSeconds(0.01f);

        AddToList();
    }
}

public class ActivatorItemV3
{
    public GameObject item;
}

