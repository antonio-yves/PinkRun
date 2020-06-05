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
        levelComplete.SetActive(true);
    }

    public void RestartGame(string levelName){
        SceneManager.LoadScene(levelName);
    }
}
