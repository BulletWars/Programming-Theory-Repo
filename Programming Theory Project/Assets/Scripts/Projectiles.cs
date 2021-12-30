using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;
   
    
    public virtual float SpeedFire()
    {
        return speed;
    }
    
}
