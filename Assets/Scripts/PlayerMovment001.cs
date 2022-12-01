using UnityEngine;

public class PlayerMovment001 : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    
    [SerializeField] private Rigidbody _rigidbody;

    


    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1

        _rigidbody.velocity = new Vector3(xMove, _rigidbody.velocity.y, zMove) * speed; // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y.
    }
}