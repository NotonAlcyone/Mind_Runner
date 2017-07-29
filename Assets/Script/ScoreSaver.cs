using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSaver : MonoBehaviour {

    string key = "HIGHSCORE";

    public Text scoreBoard;
    public Text highScore;
    public int score;

    private void Start()
    {
        highScore.text = string.Format("Best : {0:0}", scoreLoader());
    }
    private void Update()
    {
        score = (int)Time.timeSinceLevelLoad + 1;
        scoreBoard.text = string.Format("Score : {0:0}", score);
        if (score > scoreLoader())
        {
            highScore.text = string.Format("Best : {0:0}", score);
        }

    }

    int scoreLoader()
    {
        int score = 0;
        if (PlayerPrefs.HasKey(key))
        {
            score = PlayerPrefs.GetInt(key);
        }

        return score;
    }
    void scoreSaver(int score)
    {
        if (PlayerPrefs.HasKey(key))
        {
            if (PlayerPrefs.GetInt(key) < score)
            {
                PlayerPrefs.SetInt(key, score);
            }
        }
        else
        {
            PlayerPrefs.SetInt(key, score);
        }
    }
    public void GameEnd()
    {
        scoreSaver((int)score);
    }
}
