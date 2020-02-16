using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float TimeWaiting = 5f;
    [SerializeField] GameObject Anta_destra;
    [SerializeField] GameObject Anta_sinistra;


    void Start()
    {
        Anta_destra.GetComponent<MeshCollider>().isTrigger = false;
        Anta_sinistra.GetComponent<MeshCollider>().isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Anta_destra.transform.position.x - Anta_sinistra.transform.position.x);
        if (Anta_destra.transform.position.x- Anta_sinistra.transform.position.x < 2.9)
        {
           StartCoroutine(BecameTriggered(TimeWaiting));

        }
        

    }
    private IEnumerator BecameTriggered(float Timewaiting)
    {

       Anta_destra.GetComponent<MeshCollider>().isTrigger = true;
       Anta_sinistra.GetComponent<MeshCollider>().isTrigger = true;
       yield return new WaitForSeconds(Timewaiting);
        Anta_destra.GetComponent<MeshCollider>().isTrigger = false;
        Anta_sinistra.GetComponent<MeshCollider>().isTrigger = false;

    }
}
