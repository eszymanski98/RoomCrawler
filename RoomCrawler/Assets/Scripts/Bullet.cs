using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name != "Floor")
        Destroy(gameObject);
    }
}
