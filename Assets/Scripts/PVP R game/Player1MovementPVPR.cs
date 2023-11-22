using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1MovementPVPR : MonoBehaviour
{
    public float movementSpeed;
    public float rotateSpeed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3.7f)
        {
            Vector3 newPosition = new Vector2(transform.position.x, 3.7f);
            transform.position = newPosition;
        }
        if (transform.position.y < -3.7f)
        {
            Vector3 newPosition = new Vector2(transform.position.x, -3.7f);
            transform.position = newPosition;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, Input.GetAxisRaw("Vertical")) * movementSpeed;
        transform.Rotate(0, 0, Input.GetAxisRaw("Horizontal") * rotateSpeed);
        
    }
}
