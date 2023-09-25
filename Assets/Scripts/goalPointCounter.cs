using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalPointCounter : MonoBehaviour
{
    float opponentGoals = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            opponentGoals++;
            Debug.Log(opponentGoals);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
