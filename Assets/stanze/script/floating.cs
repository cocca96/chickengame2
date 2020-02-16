using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floating : MonoBehaviour
{
    // Start is called before the first frame update
    public float RandomRotationStrenght;
    public float FloatStrenght;
    [SerializeField] private GameObject chicken;
    private Animator _animatorChicken;
    public int countPatatine;
    public ButtonEasy button;

    void Start()
    {
        _animatorChicken = chicken.GetComponent<Animator>();
        countPatatine = this.transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform eachChild in transform)
        {
            
            eachChild.Rotate(RandomRotationStrenght, RandomRotationStrenght, RandomRotationStrenght);
            eachChild.GetComponent<Rigidbody>().AddForce(Vector3.down * FloatStrenght);
           
        }

        if (countPatatine == 0)
        {
            button.GetComponent<Renderer>().material.color = button.pressableColor;
        }


       
    }
    
}
