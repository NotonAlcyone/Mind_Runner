using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillControl : MonoBehaviour {

    public PlayerMovement P;
    public bool skillPhase;
    public Button button;
    private Image buttonImage;
    public float skillDuration;
    public float skillCoolTime;
    public float cutSceneTime;

    private float coolTimeChecker;
    private float passedTime;
    private float remainCoolTime;

    public GameObject skillMotion;
    private GameObject tmp;


    void Start()
    {
        coolTimeChecker = 0;// 선쿨
        passedTime = 0;
        skillPhase = false;
        buttonImage = button.GetComponent<Image>();

    }

    void Update()
    {
        if (coolTimeChecker != 0)
        {
            coolTimeChecker -= Time.deltaTime;
        }
        if (skillPhase == true)
        {

            if (passedTime >= skillCoolTime)
            {
                buttonImage.fillAmount = 1.0f;
                skillPhase = false;
                passedTime = 0;
                button.interactable = true;
            }
            else
            {
                buttonImage.fillAmount = (passedTime += Time.deltaTime) / skillCoolTime;
            }
        }



    }
    public void skillActivated()
    {
        if (coolTimeChecker <= 0)
        {
            button.interactable = false;
            skillPhase = true;
            coolTimeChecker = skillCoolTime;
            startCutScene();

        }


        /*
        if (skillStat == true)
        {
            skillStat = false;
            Debug.Log("Activated");
            Time.timeScale = 0.1f;
            Invoke("skillDeactivated", skillDuration * 0.1f);
        }
        */

    }
    void startCutScene()
    {
        Time.timeScale = 0.1f;
        tmp = Instantiate(skillMotion, transform.parent);
        Debug.Log("컷신 시작");
        Invoke("endCutScene", cutSceneTime * 0.1f);
    }
    void endCutScene()
    {
        Time.timeScale = 1.0f;
        Destroy(tmp);
        Debug.Log("컷신 끝");
        startSkill();
    }
    void startSkill()
    {
        Debug.Log("점프 3회 추가");
        P.airJump += 3;
        P.airJumpTime += 3;
        Invoke("endSkill", skillDuration);
    }
    void endSkill()
    {
        Debug.Log("점프 추가 종료");
        P.airJump -= 3;
    }
}
