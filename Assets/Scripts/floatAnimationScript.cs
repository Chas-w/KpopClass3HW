using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatAnimationScript : MonoBehaviour
{
    [SerializeField] Transform movePosition;

    Rigidbody2D rb;

    Vector3 p1, p2;

    float t;
    float jumpForce = 3f;
    bool jumping = false; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        p1 = transform.position;
        p2 = movePosition.transform.position;
    }

    int dir = 1;
    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumping = false;
        }
        */
        if (!jumping)
        { 

            if (t <= 0)
            {
                dir = 1;
            }
            else if (t >= .5)
            {
                dir = -1;
            }

            t += dir * Time.fixedDeltaTime;

            rb.MovePosition(Vector3.Lerp(p1, p2, t));
        }
    }
}
