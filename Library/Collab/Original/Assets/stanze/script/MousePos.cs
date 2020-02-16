using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
  

        private float movedownY = 0.0f;
        private float  sensitivityY =0.1f ;
        void Update()
        {
            movedownY += Input.GetAxis("Mouse Y") * sensitivityY;
            if (Input.GetAxis("Mouse Y") > 0)
            {
                transform.Translate(Vector3.up * movedownY);
            }
            if (Input.GetAxis("Mouse Y") < 0)
            {
                transform.Translate(Vector3.up * movedownY);
            }

            movedownY = 0.0f;
        }

   
}

