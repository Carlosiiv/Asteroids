﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody>().AddForce(transform.up * 350);
    }
    public void KillOldBullet()
    {
        Destroy(gameObject, 2.0f);

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Destroy(gameObject, 0.0f);
    }
}
