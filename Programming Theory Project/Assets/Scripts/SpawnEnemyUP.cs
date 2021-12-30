using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyUP : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private void Start()
    {
        InvokeRepeating("Spawn", 2f, 0.7f);
    }
    private void Spawn()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-3.3f, 3.3f), transform.position.y, transform.position.z),
        enemyPrefab.transform.rotation);
    }
}
