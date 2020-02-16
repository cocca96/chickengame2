using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyScript : MonoBehaviour
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
        //Fill -= Time.deltaTime * 0.1f;

        Bar.fillAmount = Fill;//modifichi il valore della barra Fill
        if (Fill==0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PerdeVita()
    {
        Fill -= Time.deltaTime * 0.005f;//da modificare se vogliamo più tempo
        if (Bar.fillAmount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
   
}
