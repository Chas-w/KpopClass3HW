using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnBallScript : MonoBehaviour
{
    [SerializeField] GameObject spawnLeft;
    [SerializeField] GameObject spawnRight;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject ballThrowScript;

    GameObject newBall;

    float throwCountDown = 100f;
    float ballCounter;

    float spawnRightLeft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ballCounter <= 0)
        {
            throwCountDown--;

            if (throwCountDown <= 0)
            {
                spawnRightLeft = Random.Range(0f, 1f);
                if (spawnRightLeft <= .5f)
                {
                    newBall = Instantiate(ball, spawnLeft.transform.position, spawnLeft.transform.rotation);
                    throwCountDown = 100f;
                    ballCounter++;
                }
                if (spawnRightLeft >= .5f)
                {
                    Instantiate(ball, spawnRight.transform.position, spawnRight.transform.rotation);
                    throwCountDown = 100f;
                    ballCounter++;
                }
            }
        }
        if (newBall == null)
        {
            ballCounter = 0; 
        }
    }
}
