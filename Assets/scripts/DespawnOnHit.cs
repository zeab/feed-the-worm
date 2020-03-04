using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnOnHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c)
    {
        // The position check may need to be better.
        if (c.collider.tag == "Player"){
            Debug.Log("boom!");
            Destroy(gameObject);
        }
    }
}
