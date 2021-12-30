using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTipe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
