using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{


    public Button button;
    public PlayerSkill p;
    private Image coolTime;

    void Start()
    {
        coolTime = button.GetComponent<Image>();
    }

    void Update()
    {
      
    }


}
