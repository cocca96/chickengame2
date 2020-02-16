using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Disappear : MonoBehaviour
{
    private Animator _animatorChicken;
    public GameObject player;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other == player.GetComponent<Collider>())
        {
            Debug.Log(this);
            player.GetComponent<Animator>().SetBool("gnam", true);
            renderer.enabled = false;
            StartCoroutine(gnam());

        }
    }

    private IEnumerator gnam()
    {
        this.GetComponentInParent<floating>().countPatatine -= 1;
        yield return new WaitForSeconds(1f);
        player.GetComponent<Animator>().SetBool("gnam", false);
        gameObject.SetActive(false);

    }
}
