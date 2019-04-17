using UnityEngine;
using UnityEngine.AI;

public class ItemMerchantSpawner : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;

    private Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        destination = point2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Goto(destination);
    }

    void Goto(Vector3 dest)
    {
        agent.SetDestination(dest);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "waypoint1")
        {
            destination = point2.transform.position;
        }
        if (collision.gameObject.tag == "waypoint2")
        {
            destination = point3.transform.position;
        }
        if (collision.gameObject.tag == "waypoint3")
        {
            destination = point4.transform.position;
        }
        if (collision.gameObject.tag == "waypoint4")
        {
            destination = point5.transform.position;
        }
        if (collision.gameObject.tag == "waypoint5")
        {
            destination = point1.transform.position;
        }
    }
}
