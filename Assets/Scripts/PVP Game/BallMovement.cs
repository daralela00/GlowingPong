using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startSpeed;
    public float extraSpeed;
    //public float maxSpeed;

    private int hitCounter = 0;
    public bool startPlayer1 = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Launch());
    }

    private void restartBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }

    public IEnumerator Launch()
    {
        restartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        if (startPlayer1)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float moveSpeed = startSpeed + hitCounter * extraSpeed;
        rb.velocity = direction * moveSpeed;
    }

    public void IncreaseHitCounter()
    {
        hitCounter++;
    }
}
