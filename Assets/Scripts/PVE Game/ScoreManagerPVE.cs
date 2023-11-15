using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerPVE : MonoBehaviour
{
    private int player1ScorePVE = 0;
    private int player2ScorePVE = 0;
    public static int winnerCheckPVE = -1;

    public int maxScorePVE;
    public Text player1TextPVE;
    public Text player2TextPVE;



    public void Player1GoalPVE()
    {
        player1ScorePVE++;
        player1TextPVE.text = player1ScorePVE.ToString();
        checkScorePVE();
    }

    public void Player2GoalPVE()
    {
        player2ScorePVE++;
        player2TextPVE.text = player2ScorePVE.ToString();
        checkScorePVE();
    }

    public void checkScorePVE()
    {
        /*if(player1Score == maxScore || player2Score == maxScore)
        {
            SceneManager.LoadScene("Game over");
        }*/

        if (player1ScorePVE == maxScorePVE)
        {
            winnerCheckPVE = 1;
            SceneManager.LoadScene("Game over");
        }
        if (player2ScorePVE == maxScorePVE)
        {
            winnerCheckPVE = 2;
            SceneManager.LoadScene("Game over");
        }
    }
}