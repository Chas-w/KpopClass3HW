using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArm : MonoBehaviour
{
    Rigidbody2D myBody;

    float armPower = 2; 
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myBody.AddForce(transform.up * armPower, ForceMode2D.Impulse);
        }
    }
}
