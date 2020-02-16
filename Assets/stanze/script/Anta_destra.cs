using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anta_destra : MonoBehaviour
{
 

    private void Start()
    {
        GetComponent<Collider>().isTrigger = false;

    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Anta_destra").transform.position.x >-1.14 && GameObject.FindGameObjectWithTag("Anta_destra").transform.position.x< -1.12)
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
