using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumping : MonoBehaviour {
    public Rigidbody2D enemyRigidBody;
    public float jumpForce;
    private bool skillUsed;

    private void Start()
    {
        skillUsed = false;
    } 
    private void OnTriggerEnter2D(Collider2D Detector) // collider2D 연속 충돌 체크 True 해주기
    {

        if (Detector.gameObject.tag.Equals("Player") && skillUsed == false) //스킬은 한번만 사용
        {
            Skill();
        }
    }
    void Skill()
    {
        skillUsed = true;
        enemyRigidBody.velocity = new Vector2(enemyRigidBody.velocity.x, jumpForce);
    }
}
