using UnityEngine;
using UnityEngine.InputSystem;
public class boxScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float horizontalSpeedup;
    public float maxRunSpeed;

    public float maxFallSpeed;
    public float jumpHeight;

    private Vector2 moveInput;
    private bool isGrounded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //set the horizontal movement to zero when a player stops pressing a horizontal key
        //or when changing directions
        if (moveInput.x == 0 || (moveInput.x > 0 && rigidBody.linearVelocityX < 0) || (moveInput.x < 0 && rigidBody.linearVelocityX > 0))
        {
            rigidBody.linearVelocity = new Vector2(0, rigidBody.linearVelocityY);
        }

        rigidBody.linearVelocity += new Vector2(moveInput.x * horizontalSpeedup, 0) * Time.deltaTime;

        //handle horizontal speed over the maxRunSpeed
        if (rigidBody.linearVelocityX > maxRunSpeed)
        {
            rigidBody.linearVelocity = new Vector2(maxRunSpeed, rigidBody.linearVelocityY);
        }
        else if (rigidBody.linearVelocityX < -1 * maxRunSpeed)
        {
            rigidBody.linearVelocity = new Vector2(-1 * maxRunSpeed, rigidBody.linearVelocityY);
        }

        //handle downward vertical speed over the maxFallSpeed;
        if (rigidBody.linearVelocityY < -1 * maxFallSpeed)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocityX, -1 * maxFallSpeed);
        }


      
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed && isGrounded)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocityX, jumpHeight);
        }
    }

    public void setGrounded(bool grounded)
    {
        isGrounded = grounded;
    }
}
