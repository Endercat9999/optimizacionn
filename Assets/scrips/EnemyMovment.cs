using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float moveSpeed; 

    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
       // rigidBody = GetComponent<Rigidbody2D>();
    }

  




    // Update is called once per frame
   void FixedUpdate()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        rigidBody.velocity = new Vector2(1 * moveSpeed, rigidBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            moveSpeed *= -1;
            Debug.Log("test");
        } 
    }


}
