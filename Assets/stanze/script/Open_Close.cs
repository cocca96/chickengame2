using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Open_Close : MonoBehaviour
{
    [SerializeField] private Button3D Button;
    [SerializeField] private Transform antaR;
    [SerializeField] private Transform antaL;
    private float localXPositionR;
    public float localXFinalPositionR;
    public float openDuration;
    public float releaseDuration;
    private float localXPositionL;
    public float localXFinalPositionL;



    // Start is called before the first frame update
    void Start()
    {
        localXPositionR = antaR.localPosition.x;
        localXPositionL = antaL.localPosition.x;
        Debug.Log(localXPositionR);

    }

    // Update is called once per frame
    void Update()
    {
        if(Button.isPressed== true)
        {
            doorOpen();
        }
        if (Button.isPressed == false)
        {
            doorClose();
        }
    }
    void doorOpen()
    {
        Sequence rightSequence = DOTween.Sequence();
        Sequence leftSequence = DOTween.Sequence();

        rightSequence.Append(antaR.DOLocalMoveX(localXFinalPositionR, openDuration).OnComplete(() =>
        {

        }));
        leftSequence.Append(antaL.DOLocalMoveX(localXFinalPositionL, openDuration).OnComplete(() =>
        {

        }));


    }
    void doorClose()
    {
        Sequence rightSequence = DOTween.Sequence();
        Sequence leftSequence = DOTween.Sequence();
        rightSequence.Append(antaR.DOLocalMoveX(localXPositionR, releaseDuration).OnComplete(() =>
        {

        }));
        leftSequence.Append(antaL.DOLocalMoveX(localXPositionL, releaseDuration).OnComplete(() =>
        {

        }));


    }
}
