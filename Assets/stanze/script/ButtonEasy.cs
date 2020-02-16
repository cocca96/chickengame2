using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonEasy : MonoBehaviour
{
    public Color unpressedColor;
    public Color pressableColor;
    private MeshRenderer renderer;
    private bool isTrigger = false;
    public bool isPressed = false;
    public Transform movingPieceT;
    public float localXFinalPressedPos;
    public float pressDuration = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        
        renderer = GetComponent<MeshRenderer>();
        if (renderer != null)
            renderer.material.color = unpressedColor;
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");

        if (other = player.GetComponent<Collider>() )
        {
            if (renderer.material.color == pressableColor)
            {
                Debug.Log("enter:" + other);
                isTrigger = true;
                isPressed = true;
            }

        }
        


    }
   
}
