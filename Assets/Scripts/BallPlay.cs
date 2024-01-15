using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlay : MonoBehaviour
{
    // Start is called before the first frame update
    //public Vector3 velocity;
    //public float forceMagnitude = 10.0f;
    //public Rigidbody2D rb;
   // public CollitionController cc;
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // cc.OnCollisionEnter2D(Colision);
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            // rb.AddForce(velocity);
            //Vector2 direction = transform.position - collision.contacts[0].point.normalized;
            Vector2 direction = (transform.position - collision.transform.position).normalized;


            // Apply a force to move the game object in the calculated direction
            rb.AddForce(direction * forceMagnitude, (ForceMode2D)ForceMode.Impulse);
        }
    }*/
}
