using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class goalPointCounter : MonoBehaviour
{
    float opponentGoals = 18f;
    float lives;

    [SerializeField] TMP_Text liveText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            opponentGoals--;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lives = opponentGoals / 2;
        liveText.text = $"Lives : {lives.ToString()}";

        if (lives <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
