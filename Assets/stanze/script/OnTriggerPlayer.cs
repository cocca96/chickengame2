using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlayer : MonoBehaviour
{

    void OnTriggerEnter(Collider drown)
    {
        if (drown.gameObject.name== "Player")
        {
            Debug.Log("sono qui");
            PlayerHealth health = drown.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.remove(1);
                Debug.Log("Player is drowning");
            }
            
        }
        Debug.Log(drown.gameObject.tag);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
