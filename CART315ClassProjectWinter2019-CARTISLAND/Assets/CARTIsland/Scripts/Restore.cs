using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : MonoBehaviour
{
    public GameObject triggerGameObject;

    public string objective;

    public GameObject redLED;
    public GameObject greenLED;
    public GameObject blueLED;
    public GameObject battery;
    public GameObject resistor;

    public bool isRedLED, isGreenLED, isBLueLED, isBattery, isResistor;

    // Start is called before the first frame update
    void Start()
    {
        //disables gravity and collisions
        redLED.GetComponent<Rigidbody>().useGravity = false;
        //redLED.GetComponent<BoxCollider>().enabled = false;
        greenLED.GetComponent<Rigidbody>().useGravity = false;
       // greenLED.GetComponent<BoxCollider>().enabled = false;
        blueLED.GetComponent<Rigidbody>().useGravity = false;
        //blueLED.GetComponent<BoxCollider>().enabled = false;
        battery.GetComponent<Rigidbody>().useGravity = false;
        //battery.GetComponent<BoxCollider>().enabled = false;
        resistor.GetComponent<Rigidbody>().useGravity = false;
        //resistor.GetComponent<BoxCollider>().enabled = false;


        if (isRedLED)
        {
            redLED.GetComponent<SwitchMaterial>().ChangeMaterial(1);
        }
        else
        {
            redLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }

        if (isGreenLED)
        {
            greenLED.GetComponent<SwitchMaterial>().ChangeMaterial(1);
        }
        else
        {
            greenLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }

        if (isBLueLED)
        {
            blueLED.GetComponent<SwitchMaterial>().ChangeMaterial(1);
        }
        else
        {
            blueLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }

        if (isBattery)
        {
            battery.GetComponent<SwitchMaterial>().ChangeMaterial(1);
        }
        else
        {
            battery.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }

        if (isResistor)
        {
            resistor.GetComponent<SwitchMaterial>().ChangeMaterial(1);
        }
        else
        {
            resistor.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        //check if all are available
        if(!isRedLED && !isBLueLED && !isGreenLED && !isBattery && !isResistor)
        {
            //check which objective needs to be done
            if(objective == "gravity")
            {
                triggerGameObject.GetComponent<Rigidbody>().useGravity = true;
                triggerGameObject.GetComponent<Rigidbody>().isKinematic = false;
            }

            if(objective == "trigger")
            {
                triggerGameObject.GetComponent<BoxCollider>().isTrigger = true;
            }

            if(objective == "rendererOff")
            {
                triggerGameObject.GetComponent<Renderer>().enabled = false;
                triggerGameObject.GetComponent<BoxCollider>().enabled = false;
            }

            if (objective == "rendererOn")
            {
                triggerGameObject.GetComponent<Renderer>().enabled = true;
                triggerGameObject.GetComponent<BoxCollider>().enabled = true;
            }

            if (objective == "spawner")
            {
                triggerGameObject.GetComponent<Spawner>().Spawn();
            }
        }
    }

    public bool isChallengeDone()
    {
        return (!isRedLED && !isBLueLED && !isGreenLED && !isBattery && !isResistor);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "RedLED")
        {
            isRedLED = false;
            redLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
        if (collision.gameObject.tag == "GreenLED")
        {
            isGreenLED = false;
            greenLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
        if (collision.gameObject.tag == "BlueLED")
        {
            isBLueLED = false;
            blueLED.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
        if (collision.gameObject.tag == "Battery")
        {
            isBattery = false;
            battery.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
        if (collision.gameObject.tag == "Resistor")
        {
            isResistor = false;
            resistor.GetComponent<SwitchMaterial>().ChangeMaterial(0);
        }
    }
}
