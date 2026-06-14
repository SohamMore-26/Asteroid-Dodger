using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    private float score = 0;

    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }


}
