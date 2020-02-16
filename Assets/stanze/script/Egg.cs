using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg : MonoBehaviour
{
    [SerializeField] private float FloatStrenght = 3f;

    public float RandomRotationStrenght;
   

    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
      
        GetComponent<Rigidbody>().AddForce(Vector3.down * FloatStrenght);
        transform.Rotate(RandomRotationStrenght, RandomRotationStrenght, RandomRotationStrenght);
    }
   
}

   
    


