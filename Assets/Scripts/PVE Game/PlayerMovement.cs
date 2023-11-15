using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public bool isAI;
    public GameObject ball;
    public Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAI)
        {
            AIControl();
        } else
        {
            PlayerControl();
        }
    }

    private void AIControl()
    {
        if(ball.transform.position.y > transform.position.y + 0.5f)
        {
            playerDirection = new Vector2(0, 1);
        } else if(ball.transform.position.y < transform.position.y - 0.5f)
        {
            playerDirection = new Vector2(0, -1);
        } else
        {
            playerDirection = new Vector2(0, 0);
        }
    }

    private void PlayerControl()
    {
        playerDirection =new Vector2(0, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.velocity = playerDirection * movementSpeed;
    }
}
