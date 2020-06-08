using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreUI;
    public GameObject gameOver;
    public GameObject levelComplete;
    public GameObject settingsPanel;
    public GameObject settingsButton;
    public GameObject backgroundMusic;
    // Start is called before the first frame update
    public static GameController instance;
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreUI(){
        scoreUI.text = totalScore.ToString();
    }

    public void ShowGameOver(){
        gameOver.SetActive(true);
    }

    public void ShowLevelComplete(){
        backgroundMusic.GetComponent<AudioSource>().Stop();
        Time.timeScale = 0;
        levelComplete.SetActive(true);
    }

    public void RestartGame(string levelName){
        Time.timeScale = 1;
        SceneManager.LoadScene(levelName);
    }

    public void ShowSettings(){
        settingsPanel.SetActive(true);
        settingsButton.SetActive(false);
    }

    public void CloseSettings(){
        settingsPanel.SetActive(false);
        settingsButton.SetActive(true);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
