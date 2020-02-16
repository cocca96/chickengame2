using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    private GameObject keyPresa;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");
        
        
        if (other == player.GetComponent<Collider>())
        {
            
           
            other.GetComponent<AnimatedThirdPController>().PolloGetIt = true;
            //keyPresa = GameObject.Find("keyPresa");
            //keyPresa.GetComponent<Image>().enabled = true;
            Debug.Log("CHIAVVEDEVERICOMPARIRE");
            gameObject.SetActive(false);
            AttivaChiave();
            
           
            
           // keyPresa.SetActive(true);
        }

        void AttivaChiave()
        {
            keyPresa = GameObject.Find("keyPresa");
            keyPresa.GetComponent<Image>().enabled = true;
        }



    }
}
