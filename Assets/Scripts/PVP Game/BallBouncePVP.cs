using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallBouncePVP : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreManagerPVP scoreManager;

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPoistion = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;
        float positionX;

        if(collision.gameObject.name == "player1")
        {
            positionX = 1;
        }
        else
        {
            positionX = -1;
        }

        float positionY = (ballPoistion.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "player1" || collision.gameObject.name == "player2")
        {
            Bounce(collision);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "leftCollider")
        {
            scoreManager.Player2Goal();
            ballMovement.startPlayer1 = false;
            StartCoroutine(ballMovement.Launch());
        }
        else if (collision.gameObject.name == "rightCollider")
        {
            scoreManager.Player1Goal();
            ballMovement.startPlayer1 = true;
            StartCoroutine(ballMovement.Launch());
        }
    }
}
