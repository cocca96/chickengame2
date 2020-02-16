using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    public Armadietto _door;
    public GameObject player;
    private bool isfinished;
    private BarraOssigeno barraO;
    // Start is called before the first frame update
    void Start()
    {
        isfinished = false;

}

// Update is called once per frame
void Update()
    {
        if (_door.opened == true && isfinished== false)
        {
            GetComponent<Collider>().isTrigger = true;
            barraO.ricaricaTot();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Rifill());
    }
    
    private IEnumerator Rifill()
    {
        player.GetComponent<Animator>().SetBool("oxygen", true);
        yield return new WaitForSeconds(2);
        barraO.ricaricaTot();
        //ricaricare la barra fino ad arrivare al totale

        player.GetComponent<Animator>().SetBool("oxygen", false);
        GetComponent<Collider>().isTrigger = false;
        isfinished = true;
    }
}
