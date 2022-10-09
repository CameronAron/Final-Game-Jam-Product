using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] tierOneEnemys;

    public GameObject[] tierTwoEnemys;

    public GameObject[] tierThreeEnemys;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnTierOneEnemyFiveSeconds", 0, 5f);
        InvokeRepeating("spawnTierTwoEnemyFineSeconds", 333, 5f);
        InvokeRepeating("spawnTierThreeEnemyFineSeconds", 666, 5f);
    }

    // Update is called once per frame
    public void spawnTierOneEnemyFiveSeconds()
    {
        int randEnemy = Random.Range(0, tierOneEnemys.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        var clone = Instantiate(tierOneEnemys[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        clone.SetActive(true);

    }

    public void spawnTierTwoEnemyFineSeconds()
    {
        int randEnemy = Random.Range(0, tierTwoEnemys.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        var clone = Instantiate(tierTwoEnemys[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        clone.SetActive(true);

    }

    public void spawnTierThreeEnemyFineSeconds()
    {
        int randEnemy = Random.Range(0, tierThreeEnemys.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        var clone = Instantiate(tierThreeEnemys[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        clone.SetActive(true);

    }
}
