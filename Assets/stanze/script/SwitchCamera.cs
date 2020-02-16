using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    
    public Cinemachine.CinemachineVirtualCamera CM1;
    public Cinemachine.CinemachineVirtualCamera CM2;

    void Start()
    {
        CM2.gameObject.SetActive(false);
        CM1.gameObject.SetActive(true);

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other = GameObject.Find("Player").GetComponent<Collider>())
        {
            if (CM1.gameObject.activeInHierarchy == true)
            {
                Debug.Log("hhvhhvjvjhvhj");
                CM2.gameObject.SetActive(true);
                CM1.gameObject.SetActive(false);



            }
            else
            {
                CM1.gameObject.SetActive(true);
                CM2.gameObject.SetActive(false);
            }
        }
    }
}
