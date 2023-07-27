using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class birdscript : MonoBehaviour
{
    public float ziplamasuresi;
    Rigidbody2D rb;
    public TextMeshProUGUI txtscore;
    private int score;
    public GameObject restartPanel;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * ziplamasuresi;
        }
        txtscore.text = score.ToString();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "score")
        {
            score++;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            GameOverScreen();
        }
        if (collision.gameObject.tag == "road")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            GameOverScreen();
        }
    }
    private void GameOverScreen()
    {
        restartPanel.SetActive(true);
    }
}
