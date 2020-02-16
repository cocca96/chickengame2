using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraOssigeno : MonoBehaviour
{
    public Image Bar;//questa è l'immagine della barra "figlio" quella piena "blu"
    public float Fill;
    // Start is called before the first frame update
    void Start()
    {
        Fill = 1f;
    }


    // Update is called once per frame
    void Update()
    {

        
        Bar.fillAmount = Fill;//modifichi il valore della barra Fill

    }
    public void perdeO()
    {
        Fill -= Time.deltaTime * 0.005f;//da modificare se vogliamo più tempo
        if (Bar.fillAmount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    }
    public void ricaricaTot()
    {
        Bar.fillAmount = 1f;
        Debug.Log("RICARICATO");
        //Fill += Time.deltaTime * 0.1f;
    }
}
