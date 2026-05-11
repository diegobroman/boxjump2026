using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpFactor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rigidBody.linearVelocity = Vector2.up * jumpFactor;
        }
    }
}
