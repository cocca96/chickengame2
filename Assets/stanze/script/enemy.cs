using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private bool _logCollisions = true;

    [SerializeField] private float _blinkTime = 0.05f;
    [SerializeField] private Color _blinkColor;

    private Color _originalColor;
    private Renderer _renderer;
    private bool _isBlinking = false;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer != null)
            _originalColor = _renderer.material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_logCollisions)
            Debug.Log("OnCollision ENTER");
        StartCoroutine(Blink());
    }

    private void OnCollisionStay(Collision collision)
    {
        if (_logCollisions)
            Debug.Log("OnCollision STAY");
    }

    private void OnCollisionExit(Collision collision)
    {
        if (_logCollisions)
            Debug.Log("OnCollision EXIT");
    }

    // Update is called once per frame
    public IEnumerator Blink()
    {
        if (_isBlinking)
            yield return null;

        _isBlinking = true;
        if (_renderer != null)
            _renderer.material.color = _blinkColor;

        yield return new WaitForSeconds(_blinkTime);

        if (_renderer != null)
            _renderer.material.color = _originalColor;

        _isBlinking = false;
    }
}
