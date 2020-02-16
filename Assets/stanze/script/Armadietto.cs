using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Armadietto : MonoBehaviour
{
    public Action DoorOpened;
    public Action<bool> DoorRotating;

    [SerializeField] private GameObject _doorHindge;
    [SerializeField] private float _openingTime = 1f;
    [SerializeField] private float _closingTime = 0.5f;
    public bool opened = false;

    private bool _isRotating = false;
    private bool _isOpen = false;
    private Quaternion _originalRotation;
    private GameObject key;

    private void Start()
    {
        //Debug.Log("opened" + opened);
        _originalRotation = _doorHindge.transform.localRotation;

    }

    public void OpenDoor(float rotation)
    {
        if (_isRotating || _isOpen)
            return;

        Quaternion targetRotation = Quaternion.Euler(_originalRotation.x, rotation, _originalRotation.z);
        StartCoroutine(AnimateDoor(targetRotation, _openingTime));
        key = GameObject.Find("keyPresa");
        key.GetComponent<Image>().enabled = false;


    }

   
    private IEnumerator AnimateDoor(Quaternion targetRotation, float animationTime)
    {
        _isRotating = true;

        if (DoorRotating != null)
            DoorRotating.Invoke(!_isOpen);

        float animationTimer = 0;
        Quaternion startRotation = _doorHindge.transform.localRotation;
         
        while (animationTimer < animationTime)
        {
            animationTimer += Time.deltaTime;
            _doorHindge.transform.localRotation = Quaternion.Lerp(startRotation, targetRotation, animationTimer / animationTime);
            yield return null;
        }

        _isRotating = false;
        _isOpen = !_isOpen;

        if (_isOpen && DoorOpened != null)
            DoorOpened.Invoke();
       
    }

    public void OpenAndClose(float rotation)
    {
        OpenDoor(rotation);
        Invoke("CloseDoor", _openingTime + 0.5f);
    }




}
