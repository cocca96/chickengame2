using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anta_sinistra : MonoBehaviour
{
   

    private void Start()
    {
        GetComponent<Collider>().isTrigger = false;

    }

    void Update()
        
    {
        if (GameObject.FindGameObjectWithTag("Anta_sinistra").transform.position.x > -0.15 && GameObject.FindGameObjectWithTag("Anta_sinistra").transform.position.x < -0.10)
        {
            BecameTriggered();

        }
        else
        {
            GetComponent<Collider>().isTrigger = false;
            Debug.Log("UnTriggered");
        }

    }
    public void BecameTriggered()
    {
        GetComponent<Collider>().isTrigger = true;
        Debug.Log("Triggered");

    }
    

}
