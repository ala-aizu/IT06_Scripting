using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckOnCollision : MonoBehaviour
{
    public GameObject wreckedVersion;

    public int health = 100;

    // Update is called once per frame
    void OnCollisionEnter()
    {
        health -=50;

        if (health == 0)
        {
            Destroy(gameObject);
            Instantiate(wreckedVersion,transform.position,transform.rotation);            
        }

    }
}
