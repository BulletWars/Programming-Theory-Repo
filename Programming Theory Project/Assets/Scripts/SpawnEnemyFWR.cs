using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyFWR : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 1.5f);
    }
    private void Spawn()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-3.3f, 3.3f), transform.position.y - 0.3f, transform.position.z),
        enemyPrefab.transform.rotation);
    }
}
