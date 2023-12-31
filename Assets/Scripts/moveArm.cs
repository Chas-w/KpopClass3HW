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
    void FixedUpdate()
    {
        #region moveShoulder
        if (Input.GetKey(KeyCode.H))
        {
            myBody.AddForce(Vector2.up * armPower, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.K))
        {
            myBody.AddForce(Vector2.down * armPower, ForceMode2D.Impulse);
        }
        #endregion
    }
}
