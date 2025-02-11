using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{
    public float speed = 5f;

    public void Shoot(Vector2 direction)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction * speed;
    }

    private void OnBecameInvisible()
    {
        ObjectPool pool = FindObjectOfType<ObjectPool>();
        pool.ReturnObject(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ObjectPool pool = FindObjectOfType<ObjectPool>();
            pool.ReturnObject(gameObject);
        }
    }

}
