using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score, highscore;

    public Text scoreText, highscoreText;
    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        score = PlayerPrefs.GetInt("score");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    void Update()
    {
        highscoreText.text = highscore.ToString();
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        highscoreText.text = "Highest: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
