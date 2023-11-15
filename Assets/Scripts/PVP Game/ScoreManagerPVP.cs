using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerPVP : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;
    public static int winnerCheck = -1;

    public int maxScore;
    public Text player1Text;
    public Text player2Text;



    public void Player1Goal()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        checkScore();
    }

    public void Player2Goal()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        checkScore();
    }

    public void checkScore()
    {
        /*if(player1Score == maxScore || player2Score == maxScore)
        {
            SceneManager.LoadScene("Game over");
        }*/

        if (player1Score == maxScore)
        {
            winnerCheck = 1;
            SceneManager.LoadScene("Game over");
        }
        if(player2Score == maxScore)
        {
            winnerCheck = 2;
            SceneManager.LoadScene("Game over");
        }
    }
}