using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DictLocker : MonoBehaviour {

    public Text[] texts;
    public SpriteRenderer[] sprites;

    public string[] description;
	void Start () {
        checker("Witch","Witch(Clone)",0);
        checker("Enemy", "Enemy(Clone)", 1);
        checker("Normal", "Normal(Clone)", 2);



    }


    public void goBack()
    {
        SceneManager.LoadScene("SelectScene");
    }

    void checker(string key1,string key2,int num)
    {
        if (PlayerPrefs.HasKey(key1) == true || PlayerPrefs.HasKey(key2) == true)
        {
            texts[num].text = description[num];
            sprites[num].enabled = true;
        }
        else
        {
            texts[num].text = "?";
            sprites[num].enabled = false;
        }


    }
}
