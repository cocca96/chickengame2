using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Button3D : MonoBehaviour
{
    public Action OnButtonPressed;

    public Transform movingPieceT;
    public float localYFinalPressedPos;
    public float pressDuration = 0.3f;
    public float releaseDuration = 0.1f;

    public bool isPressed = false;







    public Color unpressedColor;
    public Color pressedColor;
    private MeshRenderer renderer;
    private float initialLocalYPos;
    private bool isTrigger = false;
    private float tempo;

    void Start()
    {
        initialLocalYPos = movingPieceT.localPosition.y;

        renderer = movingPieceT.GetComponent<MeshRenderer>();
        if (renderer != null)
            renderer.material.color = unpressedColor;

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter:" + other);
        ReliableOnTriggerExit.NotifyTriggerEnter(other, gameObject, OnTriggerExit);
        if (other != GameObject.Find("Base").GetComponent<Collider>())
        {
            isTrigger = true;
            StartCoroutine(Press(tempo));

        }
        Debug.Log("enter:" + other);


    }
    private void OnTriggerExit(Collider other)
    {
        ReliableOnTriggerExit.NotifyTriggerExit(other, gameObject);
        isTrigger = false;
        if (other != GameObject.Find("Base").GetComponent<Collider>())
        {
            tempo = 0.1f;
            isTrigger = false;
            if (other == GameObject.Find("Player").GetComponent<Collider>())
            {

                StartCoroutine(Press(tempo));
            }
            else { tempo = 5f;
                StartCoroutine(Press(tempo));
                    }
        }

       

    }



    private IEnumerator Press(float time)
    {
        Sequence pressSequence = DOTween.Sequence();

        if (isTrigger == true)
        {
            Debug.Log("Triggering");
            renderer.material.color = pressedColor;
            isPressed = true;
            pressSequence.Append(movingPieceT.DOLocalMoveY(localYFinalPressedPos, pressDuration).OnComplete(() =>
            {
                renderer.material.color = pressedColor;

                Debug.Log("pressed");


            }));
        }
        if (isTrigger == false)
        {
            yield return new WaitForSeconds(time);
            isPressed = false;
            renderer.material.color = unpressedColor;
            pressSequence.Append(movingPieceT.DOLocalMoveY(initialLocalYPos, releaseDuration));
            pressSequence.OnComplete(() =>
            {
                renderer.material.color = unpressedColor;
                Debug.Log("unpressed");
                isTrigger = false;
                if (renderer != null)
                    renderer.material.color = unpressedColor;
            });
        }
    }



}
