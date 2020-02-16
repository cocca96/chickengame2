using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float startingHealth = 10f;
    public float currentHealth;
    private GameObject goBar;
    private GameObject barre;
    private GameObject key;

    private MyScript script;

    private GameObject uovo;
   
   

   
   void ChangeBarSize(float size)
    {
        goBar = GameObject.Find("ImgFilled");
        if (goBar)
        {
            //Debug.Log("Name: " + goBar.name);
            Image img = goBar.GetComponent<Image>();
            if (img != null)
            {
                //Debug.Log("Img comp trovata: " + img.name);

                //img.fillAmount = 0.5f;
                script = img.GetComponent<MyScript>();

                script.Fill -= size;
            }
            else
            {
                Debug.Log("no img comp trovata");
            }
        }
        else
        {
            Debug.Log("No game object called canvas");
        }
    }
    void PolloCova()
    {
        uovo = GameObject.Find("UovoCanvas");
        uovo.SetActive(false);

    }
    void Awake()
    {
        currentHealth = startingHealth;
        //barre = GameObject.Find("TotaleCanvas");
       // barre.GetComponent<Canvas>().enabled = false;
        //key = GameObject.Find("keyPresa");
        //key.GetComponent<Image>().enabled = false;


    }
    private void Start()
    {
        barre = GameObject.Find("TotalCanvastranneKey");
        barre.GetComponent<Canvas>().enabled = false;
        key = GameObject.Find("keyPresa");
        key.GetComponent<Image>().enabled = false; 
        /*barre = GameObject.Find("TotaleCanvas");
         barre.GetComponent<Canvas>().enabled = false;
        key = GameObject.Find("keyPresa");
        key.GetComponent<Image>().enabled = false;*/

    }


    void Update()
    {

        if (currentHealth <= 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }

    }

    public void remove(float amount)
    {
        
        currentHealth -= amount;
        Debug.Log(currentHealth);
        ChangeBarSize(0.1f);

       // script.PerdeV();

    }

}
