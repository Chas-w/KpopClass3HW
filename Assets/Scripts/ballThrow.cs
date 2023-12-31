using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThrow : MonoBehaviour
{
    [SerializeField] GameObject playerBody;
    [SerializeField] GameObject self;
    Rigidbody2D ballBody;

    float throwForce = 2f;
    float throwingPeriod = 10f;

    // Start is called before the first frame update
    void Start()
    {
        ballBody = GetComponent<Rigidbody2D>();
        self = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (throwingPeriod > 0)
        {
            if (transform.position.x <= playerBody.transform.position.x)
            {
                ballBody.AddForce(Vector2.right * throwForce, ForceMode2D.Impulse);
                throwingPeriod--;
            }
            if (transform.position.x >= playerBody.transform.position.x)
            {
                ballBody.AddForce(Vector2.left * throwForce, ForceMode2D.Impulse);
                throwingPeriod--;
            }

        }
        
    }
}
