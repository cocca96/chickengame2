using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_controll : MonoBehaviour
{
    RectTransform m_RectTransform;
    Vector3 length = new Vector3(0, 0, 0);



    // Start is called before the first frame update
    void Start()
    {
        m_RectTransform = GetComponent<RectTransform>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
        m_RectTransform.localPosition = GameObject.FindWithTag("Player").transform.position+length;
       

    }
}
