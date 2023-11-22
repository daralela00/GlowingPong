using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerPVPR : MonoBehaviour
{
    private int player1ScorePVPR = 0;
    private int player2ScorePVPR = 0;
    public static int winnerCheckPVPR = -1;

    public int maxScorePVPR;
    public Text player1TextPVPR;
    public Text player2TextPVPR;



    public void Player1GoalPVPR()
    {
        player1ScorePVPR++;
        player1TextPVPR.text = player1ScorePVPR.ToString();
        checkScorePVPR();
    }

    public void Player2GoalPVPR()
    {
        player2ScorePVPR++;
        player2TextPVPR.text = player2ScorePVPR.ToString();
        checkScorePVPR();
    }

    public void checkScorePVPR()
    {
        /*if(player1Score == maxScore || player2Score == maxScore)
        {
            SceneManager.LoadScene("Game over");
        }*/

        if (player1ScorePVPR == maxScorePVPR)
        {
            winnerCheckPVPR = 1;
            SceneManager.LoadScene("Game over");
        }
        if (player2ScorePVPR == maxScorePVPR)
        {
            winnerCheckPVPR = 2;
            SceneManager.LoadScene("Game over");
        }
    }
}
