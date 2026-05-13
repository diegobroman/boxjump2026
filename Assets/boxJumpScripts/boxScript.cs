using UnityEngine;
using UnityEngine.InputSystem;
public class boxScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float horizontalSpeedup;
    public float maxRunSpeed;

    public float verticalSpeedup;
    public float maxFallSpeed;
    public float jumpHeight;

    private Vector2 moveInput;
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

        rigidBody.linearVelocity += new Vector2(moveInput.x * horizontalSpeedup, moveInput.y * verticalSpeedup) * Time.deltaTime;

        //handle horizontal speed over the maxRunSpeed
        if (rigidBody.linearVelocityX > maxRunSpeed)
        {
            rigidBody.linearVelocity = new Vector2(maxRunSpeed, rigidBody.linearVelocityY);
        }
        else if (rigidBody.linearVelocityX < -1 * maxRunSpeed)
        {
            rigidBody.linearVelocity = new Vector2(-1 * maxRunSpeed, rigidBody.linearVelocityY);
        }

        


      
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocityX, jumpHeight);
        }
    }
}
