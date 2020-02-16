using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Armadietto _door;
    private void OnTriggerEnter(Collider other)
    {
        //the result of the dot product returns > 0 if relative position 
        //float dotResult = Vector3.Dot(othersPositionRelativeToDoor, transform.forward);

        if (other.GetComponent<AnimatedThirdPController>().PolloGetIt == true)
        {
           
            float doorRotation = -90f;

            if (_door != null)
                _door.OpenDoor(doorRotation);
                _door.opened = true;

        }

    }

    
}
