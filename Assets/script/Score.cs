using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private int bestScore = 0;
    private int score;
    private float time=0.2f;

    private void Awake()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            score += 100;
            time = 0.2f;
        }
        
        scoreText.text = string.Format("Score: {0:F0}", score);
        gameOverScoreText.text = string.Format("    Score: {0:F0}", score);
        bestScoreText.text = string.Format("BestScore: {0:F0}", bestScore);

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
}
