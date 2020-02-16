using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampeggio : MonoBehaviour

{
    public Color acceso;
    public Color spento;
    public float timeAcceso;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        renderer.material.color = spento;
        StartCoroutine(Lampeggio(timeAcceso));
    }

    // Update is called once per frame
    private IEnumerator Spento()
    {
        renderer.material.color = spento;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Lampeggio(timeAcceso));
    }

    private IEnumerator Lampeggio(float time)
    {
       
        renderer.material.color = acceso;
        yield return new WaitForSeconds(time);
        StartCoroutine(Spento());

    }
}
