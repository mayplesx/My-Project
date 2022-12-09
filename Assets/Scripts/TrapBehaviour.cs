using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public Enemy enemyPrefab;

public Transform enemySpawn1;
public Transform enemySpawn2;
public Transform enemySpawn3;
public Transform player;

  void OnTriggerEnter2D(Collider2D collider)
  {
    if(collider.tag == "Player")
    {
        Enemy enemy1 = Instantiate(enemyPrefab, enemySpawn1) as Enemy;
        enemy1.target = player;

        Enemy enemy2 = Instantiate(enemyPrefab, enemySpawn2) as Enemy;
        enemy2.target = player;

        Enemy enemy3 = Instantiate(enemyPrefab, enemySpawn3) as Enemy;
        enemy3.target = player;

        Destroy(gameObject);
    }
  }
}
