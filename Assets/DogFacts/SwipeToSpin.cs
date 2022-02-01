using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeToSpin : MonoBehaviour
{
    [SerializeField]
    private float multiplierY=0.02f;
    [SerializeField]
    private float _speed = 100;
    [SerializeField]
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.forward, _speed);
            rb.AddForce(Vector3.up * 7);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.forward, _speed * -1);
        }
    }
    
}
