using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text goText;
    public GameObject replayButton;
    public GameObject mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        if(ScoreManagerPVP.winnerCheck == 1 || ScoreManagerPVE.winnerCheckPVE == 1 || ScoreManagerPVPR.winnerCheckPVPR == 1)
        {
            goText.text = "Player 1 wins!";
        }
        else if(ScoreManagerPVP.winnerCheck == 2 || ScoreManagerPVE.winnerCheckPVE == 2 || ScoreManagerPVPR.winnerCheckPVPR == 2)
        {
            goText.text = "Player 2 wins!";
        }

        if(ScoreManagerPVE.winnerCheckPVE == 1 || ScoreManagerPVE.winnerCheckPVE == 2)
        {
            goText.color = Color.red;
            replayButton.GetComponent<Image>().color = Color.red;
            mainMenuButton.GetComponent<Image>().color = Color.red;
        }

        if(ScoreManagerPVPR.winnerCheckPVPR == 1 || ScoreManagerPVPR.winnerCheckPVPR == 2)
        {
            goText.color = Color.blue;
            replayButton.GetComponent<Image>().color = Color.blue;
            mainMenuButton.GetComponent<Image>().color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReaplayGame()
    {
        if(ScoreManagerPVP.winnerCheck == 1 || ScoreManagerPVP.winnerCheck == 2)
        {
            SceneManager.LoadScene("PVP Game");
        } else if(ScoreManagerPVE.winnerCheckPVE == 1 || ScoreManagerPVE.winnerCheckPVE == 2)
        {
            SceneManager.LoadScene("PVE Game");
        }
    }

    public void GoToMainMenu()
    {
        ScoreManagerPVP.winnerCheck = -1;
        ScoreManagerPVE.winnerCheckPVE = -1;
        ScoreManagerPVPR.winnerCheckPVPR = -1;
        SceneManager.LoadScene("Main Menu");
    }
}
