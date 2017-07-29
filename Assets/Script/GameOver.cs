using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Start () {
		Time.timeScale = 0.0f;
	}
	
	void Update () {
		
	}
    public void main()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SelectScene");

    }
    public void retry()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("main");
    }
}
