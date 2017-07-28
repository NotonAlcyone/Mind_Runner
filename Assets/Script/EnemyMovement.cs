using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int moveSpeed;

    public LayerMask groundLayer;

    private Animator anime;
    private Rigidbody2D enemyRigidBody;
    private Collider2D enemyCollider;

    private bool isGrounded;
    public GameObject destroyPoint;




    void Start()
    {
        anime = GetComponent<Animator>();
        enemyRigidBody = GetComponent<Rigidbody2D>();
        enemyCollider = GetComponent<Collider2D>();
        destroyPoint = GameObject.Find("DestroyPoint"); // 생성시 파괴 위치 확인
    }
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(enemyCollider, groundLayer);
        anime.SetFloat("Speed", moveSpeed * -1);
        anime.SetBool("Grounded", isGrounded);
        enemyRigidBody.velocity = new Vector2((moveSpeed), enemyRigidBody.velocity.y);

        if (transform.position.x < destroyPoint.transform.position.x) //destroyPoin의 x를 넘어서면
        {
            Destroy(gameObject);//파.개
        }
    }

}
