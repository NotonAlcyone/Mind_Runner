using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D playerRigidbody;
    private Collider2D collision;
    
    private Animator anime;

    public SkillControl skill;
    public BackgroundControl Bg;
    public ScoreSaver score;

    public int jumpForce;

    public int airJump;
    public int airJumpTime;

    public bool isGrounded;

    public LayerMask groundLayer;
    public LayerMask goalLayer;
    public GameObject jumpEffect;
    public GameObject gameEnd;
    public Canvas can;
    private bool end;
    void Start()
    {
        end = false;
        anime = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();
        Physics2D.IgnoreLayerCollision(9, 10); //플레이어와 장애물의 물리적 충돌 배제
    }

    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(collision, groundLayer); //지상과 충돌 체크
        if (isGrounded == true)
        {
            airJumpTime = airJump;
        }


        anime.SetFloat("Move", Bg.Speed[0]);
        anime.SetBool("Grounded", isGrounded);
        anime.SetBool("Skill",skill.skillStat);
    }

    public void jumpcheck()
    {
      
            if (isGrounded == true) // 지상이라면 점프
            {
                playerJump();
            }
            else if (isGrounded == false && airJumpTime > 0) // 공중이라면 다단점프 잔여 체크
            {
                airJumpTime--;
                Instantiate(jumpEffect, transform.position, transform.rotation, transform);

                playerJump();
            }
        
    }

    private void OnTriggerEnter2D(Collider2D enemyTrigger) // collider2D 연속 충돌 체크 True 해주기
    {
        
        if (enemyTrigger.gameObject.tag.Equals("Enemy") && end == false)
        {
            end = true;
            Debug.Log(enemyTrigger.gameObject.name);
            PlayerPrefs.SetString(enemyTrigger.gameObject.name, "true");
            skill.button.enabled = false;
            score.GameEnd();
            Instantiate(gameEnd,can.transform);
        }
        
    }
    void playerJump()
    {
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, jumpForce);
    }

}
