using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public int moveSpeed;
    private Rigidbody2D enemyRigidBody;
    public GameObject destroyPoint;//Prefab화 시켜서 Link

	void Start () {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        //destroyPoint = GameObject.Find("EnemyDestroyPoint");
    }
	
	void Update () {
        enemyRigidBody.velocity = new Vector2((moveSpeed), 0);
        if (transform.position.x < destroyPoint.transform.position.x) //destroyPoin의 x를 넘어서면
        {
           
            Destroy(gameObject);
        }
    }
}
