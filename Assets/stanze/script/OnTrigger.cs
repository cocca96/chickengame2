using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour
{
    [SerializeField] private float TimeWaiting = 3f;
    [SerializeField] private bool isSchiacciato;
    private MyScript script;
    private GameObject goBar;//non c'era più
    private BarraOssigeno barraO;//aggiunto
    public GameObject player;

    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other== player.GetComponent<Collider>() && isSchiacciato == false)
        {
            StartCoroutine(ReduceLife(other, TimeWaiting));
            //script.PerdeV();
            //ChangeBarSize(0.1f);//aggiunto
        }


    }
    void ChangeBarSize(float size) //blocco aggiuntoo
    {
        goBar = GameObject.Find("ImgFilled");
        if (goBar)
        {
            Debug.Log("Name: " + goBar.name);
            Image img = goBar.GetComponent<Image>();
            if (img != null)
            {
                Debug.Log("Img comp trovata: " + img.name);

                //img.fillAmount = 0.5f;
               // script = img.GetComponent<MyScript>();
                //script.Fill -= size;
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

    // Update is called once per frame
    private IEnumerator ReduceLife(Collider other,float time)
    {
        isSchiacciato = true;

        PlayerHealth health = other.GetComponent<PlayerHealth>();
        if (health.currentHealth != 0)
        {
            health.remove(1);
            Debug.Log("colpito");
            
            yield return new WaitForSeconds(time);
            isSchiacciato = false;


        }
        if (health.currentHealth == 0)
        {
            Debug.Log("DEAD");
        }

    }
   
    void Update()
    {
        
    }
}
