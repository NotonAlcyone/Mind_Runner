using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScene : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
    public void goBack()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
