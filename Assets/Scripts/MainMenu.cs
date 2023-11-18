using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject pvpButton;
    public GameObject pveButton;
    public GameObject pvpRotateButton;
    public GameObject backButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        playButton.SetActive(false);
        quitButton.SetActive(false);
        pvpButton.SetActive(true);
        pveButton.SetActive(true);
        pvpRotateButton.SetActive(true);
        backButton.SetActive(true);
    }

    public void PvpPlay()
    {
        SceneManager.LoadScene("PVP Game");
    }

    public void PvePlay()
    {
        SceneManager.LoadScene("PVE Game");
    }

    public void PvprPlay()
    {
        SceneManager.LoadScene("PVP R Game");
    }
    public void Back()
    {
        playButton.SetActive(true);
        quitButton.SetActive(true);
        pvpButton.SetActive(false);
        pveButton.SetActive(false);
        pvpRotateButton.SetActive(false);
        backButton.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
