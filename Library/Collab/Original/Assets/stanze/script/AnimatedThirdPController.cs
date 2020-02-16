using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedThirdPController : MonoBehaviour
{
    [SerializeField] private Transform _cameraT;
    public float _speed = 5f;
    [SerializeField] private float _rotationSpeed = 3f;
    [SerializeField] GameObject egg_Object;
    public bool PolloGetIt = false;

    private Animator _animator;

    private Vector3 _inputVector;
    private float _inputSpeed;
    private Vector3 _targetDirection;
    private bool _isCoving = false;
    private bool egg_isOut = false;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Handle the Input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        _inputVector = new Vector3(h, 0, v);
        _inputSpeed = Mathf.Clamp(_inputVector.magnitude, 0f, 1f);

        UpdateAnimations();

        //Compute direction According to Camera Orientation
        _targetDirection = _cameraT.TransformDirection(_inputVector).normalized;
        _targetDirection.y = 0f;


        if (_inputSpeed <= 0f || _isCoving)
            return;

  
        //Calculate rotation vector and rotate
        Vector3 newDir = Vector3.RotateTowards(transform.forward, _targetDirection, _rotationSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(newDir);

        //Translate along forward
        transform.Translate(transform.forward * _inputSpeed * _speed * Time.deltaTime, Space.World);

     


    }

    private void UpdateAnimations()
    {
        _animator.SetFloat("speed", _inputSpeed);

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(Cova(2f));

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Becca(1f));
        }


    }

    private IEnumerator Cova(float time)
    {
        _animator.SetBool("cova", true);
        Egg_controller egg = GetComponent<Egg_controller>();
        if (egg != null)
        {
            yield return new WaitForSeconds(time);
            if (egg_Object.GetComponent<MeshRenderer>().enabled == false)
            egg.move();
           
        }

        _animator.SetBool("cova", false);
    }
    private IEnumerator Becca(float time)
    {
        _animator.SetBool("Becca", true);

        yield return new WaitForSeconds(time);
        _animator.SetBool("Becca", false);
    }



}




