using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float move_speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Better for handling inputs
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");    // You can find these names in 
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // An update that is independent of the frame rate, called on a fixed timer
    // More reliable for physics and movement
    void FixedUpdate()
    {
        // Should we normalize the movement vector?
        float m = movement.magnitude;
        if (m > 0)
        {
            rb.MovePosition(rb.position + (movement / m) * move_speed * Time.fixedDeltaTime);
        }
    }
}
