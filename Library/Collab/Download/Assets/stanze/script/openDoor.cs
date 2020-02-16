using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class openDoor : MonoBehaviour
{
    [SerializeField] private ButtonEasy Button;
    [SerializeField] private Transform antaR;
    [SerializeField] private Transform antaL;
    private float localXPositionR;
    public float localXFinalPositionR;
    private float localXPositionL;
    public float localXFinalPositionL;
    public float openDuration;
    private GameObject barre;
    private GameObject keyPresa;
    public CountDown countDown;
    public BarraOssigeno barraOssigeno;
    
    

    // Start is called before the first frame update
    void Start()
    {
        

        localXPositionR = antaR.localPosition.x;
        localXPositionL = antaL.localPosition.x;
        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Button.isPressed == true)
        {
            
            doorOpen();

            barre = GameObject.Find("TotalCanvastranneKey");
            barre.GetComponent<Canvas>().enabled = true;
            /*barre = GameObject.Find("TotaleCanvas");
            barre.GetComponent<Canvas>().enabled = true;
            Debug.Log("SCHERMO ATTIVO");*/

           // keyPresa = GameObject.Find("keyPresa");


            //keyPresa.GetComponent<Image>().enabled = false;
            Debug.Log("NOCHIAVESISCHERMO");
            
            countDown.SetTimer(600);
            barraOssigeno.perdeO();

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
    //mettere qui SetTimer

}
