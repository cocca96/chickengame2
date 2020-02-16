using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
    
{
    [SerializeField] private int lives = 3;
    [SerializeField] private float TimeWaiting = 3f;
    private GameObject uovo; 
    private MyScript script; 
    


    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(die(TimeWaiting));
       
    }
    private IEnumerator die(float time)
    {
        lives -= 1;

        //script.PerdeV();
        Debug.Log("lives:" + lives);
        yield return new WaitForSeconds(time);

    }
    // Start is called before the first frame update
    void PolloCova()
    {
        uovo = GameObject.Find("UovoCanvas");
        uovo.SetActive(false);

    }
    void Start()
    {

        
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
