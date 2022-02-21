using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2);

    }
    [SerializeField] private List<Enemy> enemies;
    void SpawnEnemy()
    {
        int enemyToSpawn = Random.Range(0, 2);
        Vector3 spawnpos = new Vector3(15, Random.Range(-7.0f, 7.0f), 0);
        Instantiate(enemies[enemyToSpawn], spawnpos, transform.rotation);
    }
}
