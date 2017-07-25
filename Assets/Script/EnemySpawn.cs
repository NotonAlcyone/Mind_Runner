using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] enemy;
    public GameObject spawnPoint;
    public float invokeTime;

	void Start () {
        InvokeRepeating("enemySpawn", 1, invokeTime);
    }
	
	void Update () {
		
	}

    void enemySpawn()
    {
        Transform shortCut = spawnPoint.transform;
        Instantiate(enemy[Random.Range(0, enemy.Length)],shortCut.position,shortCut.rotation,shortCut);
    }
}
