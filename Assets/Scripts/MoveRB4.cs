using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class MoveRB4 : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            jump();
        }
    }

    void jump()
    {

        _rigidbody.AddRelativeForce(Vector3.up * _jumpForce);
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical"); 
        float r = Input.GetAxisRaw("Mouse X");
        Vector3 force = new Vector3(h,0f,v) * _force;
        _rigidbody.AddRelativeForce(force);

        transform.Rotate(0f, r * _rotationSpeed, 0f);
    }
}


 