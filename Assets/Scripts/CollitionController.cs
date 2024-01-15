using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollitionController : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceMagnitude = 10.0f;
    public Rigidbody2D rb;
    // public BallPlay bp;
    public Transform initialPositionBall;
    public Transform initialRotationPlayer;
    private void Start()
    {
        //bp = GetComponent<Rigidbody2D>();
        //bp.GetComponent<Rigidbody2D>().mass = forceMagnitude;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("TopBar") || collision.gameObject.CompareTag("LeftBar")|| collision.gameObject.CompareTag("RightBar"))
        {
            // rb.AddForce(velocity);
            //Vector2 direction = transform.position - collision.contacts[0].point.normalized;
            Vector2 direction = (transform.position - collision.transform.position).normalized;


            // Apply a force to move the game object in the calculated direction
            rb.AddForce(direction * forceMagnitude, (ForceMode2D)ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("BottomBar"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
