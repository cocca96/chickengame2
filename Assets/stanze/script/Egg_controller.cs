using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg_controller : MonoBehaviour
{
    [SerializeField] private GameObject egg;
    [SerializeField] private float survive;
    private GameObject uovo;







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
     
    }
    public void move()
    {
      egg.transform.position = transform.position;
        if (egg.GetComponent<MeshRenderer>().enabled != true) {
            StartCoroutine(Egg_duration(survive));
           
            egg.GetComponent<MeshRenderer>().enabled = true;
        }
     
    }
    private IEnumerator Egg_duration(float time)
    {
        
        egg.SetActive(true);
        StartCoroutine(PolloCova(survive));
        egg.GetComponent<Collider>().enabled = true;
        egg.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(time);
        

        egg.SetActive(false);
        
        
        egg.GetComponent<MeshRenderer>().enabled = false;
        egg.GetComponent<Collider>().enabled = false;

        
        
      
        


    }
    private IEnumerator PolloCova(float time)
    {
        uovo = GameObject.Find("UovoCanvas");
        uovo.SetActive(false);
        yield return new WaitForSeconds(time);
        uovo.SetActive(true);


    }
 
}
