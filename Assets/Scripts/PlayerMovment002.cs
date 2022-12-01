using UnityEngine;

public class PlayerMovment002 : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier
    public float speedy = 1f; //Controls velocity multiplier

    [SerializeField] private Rigidbody _rigidbody;



    void Start()
    {

        if (_rigidbody==null)
            _rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(mH * speed, _rigidbody.velocity.y* speedy, mV * speed);

    }

}



