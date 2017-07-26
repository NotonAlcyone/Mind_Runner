using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour {
    public bool skillStat;
    public float skillDuration;
    public float skillCoolTime;

    void Start () {
        skillStat = true;

    }
	
	void Update () {
		
	}
    public void skillActivated()
    {
        if (skillStat == true)
        {
            skillStat = false;
            Debug.Log("Activated");
            Time.timeScale = 0.1f;
            Invoke("skillDeactivated", skillDuration*0.1f);
        }

    }
    void skillDeactivated()
    {
        Time.timeScale = 1;
        Invoke("skill", skillCoolTime);
    }
    void skill()
    {
        Debug.Log("스킬 사용가능");
        skillStat = true;
    }
}
