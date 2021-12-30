using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDown : EnemyClass
{

    public override void MovingEnemy()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);  
    }
    
        
}
