using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] enemyPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemyFiveSeconds", 0, 5f);
    }

    // Update is called once per frame
    public void spawnEnemyFiveSeconds()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}
