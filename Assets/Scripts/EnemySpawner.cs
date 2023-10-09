using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject[] enemyPrefabs;
    public float moveSpeed=8f; 
    void Start()
    {
        StartCoroutine(Spawn());
    }

    
    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(10f);
            int randomEnemyIndex = Random.Range(0, enemyPrefabs.Length) ;
            int randomSpawnIndex = Random.Range(0, spawnPoint.Length);

            Transform spawnPosition = spawnPoint[randomSpawnIndex].transform;
            GameObject enemyClone=Instantiate(enemyPrefabs[randomEnemyIndex],spawnPosition.position,Quaternion.identity);

            EnemyMovement enemyScript = enemyClone.GetComponent<EnemyMovement>();

        }
    }
}
