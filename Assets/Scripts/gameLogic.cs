using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    private float score = 0;
    public GameObject gameOverScreen;

    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        score = 0;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); 
    }

}
