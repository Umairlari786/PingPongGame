using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection();
        
    }

    public void MoveDirection() 
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            float moveDirection = Input.GetAxis("Horizontal") * speed;
            moveDirection *= Time.deltaTime;
            float newPosition = transform.position.x + moveDirection;
            newPosition = Mathf.Clamp(newPosition, -5.44f, 5.44f);
            transform.position = new Vector3(newPosition, -3.46f, 0);
        }
    }
}
