using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ballBlocked : MonoBehaviour
{
    float gameCountDown = 30f;
    float ballsBlocked;
    [SerializeField] TMP_Text count;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
       if (gameCountDown >= 0)
        {
            gameCountDown-= Time.deltaTime;
            Debug.Log(gameCountDown);
            count.text = $"Time: {gameCountDown.ToString()}";
        }
       if (gameCountDown <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
