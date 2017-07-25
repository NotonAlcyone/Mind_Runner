using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaver : MonoBehaviour {

    string key = "HIGHSCORE";

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
}
