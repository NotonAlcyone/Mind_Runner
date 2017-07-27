using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public int moveSpeed;

    public LayerMask groundLayer;


    private Animator anime;
    private Rigidbody2D enemyRigidBody;
    public Collider2D enemyCollider;

    private bool isGrounded;
    public GameObject destroyPoint;//Prefab화 시켜서 Link
    private bool skillUsed;
	void Start () {

        skillUsed = false;
        anime = GetComponent<Animator>();
        enemyRigidBody = GetComponent<Rigidbody2D>();
        enemyCollider = GetComponent<Collider2D>();
        destroyPoint = GameObject.Find("DestroyPoint");

    }
	
	void Update () {
        isGrounded = Physics2D.IsTouchingLayers(enemyCollider, groundLayer);
        anime.SetFloat("Speed", moveSpeed * -1);
        anime.SetBool("Grounded", isGrounded);
        enemyRigidBody.velocity = new Vector2((moveSpeed), enemyRigidBody.velocity.y);

        if (transform.position.x < destroyPoint.transform.position.x) //destroyPoin의 x를 넘어서면
        {      
            Destroy(gameObject);
        }

    

    }
    private void OnTriggerEnter2D(Collider2D Detector) // collider2D 연속 충돌 체크 True 해주기
    {

        if (Detector.gameObject.tag.Equals("Player") && skillUsed == false)
        {
            Jump();
        }

    }

    void Jump()
    {
        skillUsed = true;
        enemyRigidBody.velocity = new Vector2(enemyRigidBody.velocity.x, 7);
    }
}
