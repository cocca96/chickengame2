using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public BarraOssigeno barraO;
    public GameObject goBarO;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)

    {
        GameObject player = GameObject.Find("Player");
        if (other == player.GetComponent<Collider>())
        {
            
            Debug.Log("ENTRATO");
            ChangeBarOxygenSize(0.4f);
            //devo far diminuire la barra dell'ossigeno
            //una volta aperto l'armadio devo far ricaricare tutta la barra e devo eliminarla dalll'interfaccia
        }
    }
    void ChangeBarOxygenSize(float size)
    {
        goBarO= GameObject.Find("ImgFilledO");
        if (goBarO)
        {
            Debug.Log("Name: " + goBarO.name);
            Image img = goBarO.GetComponent<Image>();
            if (img != null)
            {
                Debug.Log("Img comp trovata: " + img.name);

                //img.fillAmount = 0.5f;
                barraO = img.GetComponent<BarraOssigeno>();
                barraO.Fill += size;
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


}
