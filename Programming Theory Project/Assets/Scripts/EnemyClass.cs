using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    public float speed;
 
    public virtual void MovingEnemy()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    private void Update()
    {
        MovingEnemy();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
