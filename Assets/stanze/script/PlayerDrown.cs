using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrown : MonoBehaviour
{
    void OnTriggerEnter(Collider drown)
    {
        if (drown.gameObject.tag == "Player")
        {
            Debug.Log("sono qui");
            PlayerHealth health = drown.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.remove(1);
                Debug.Log("Player is drowning");
            }
        }
    }


}
