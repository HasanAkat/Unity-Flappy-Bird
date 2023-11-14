using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public bool isdead;
    public float velocity = 1f;
    public Rigidbody2D rb;
    public manager manager;
    public GameObject gameover;
    public GameObject gamestart;

    public void Start()
    {
        Time.timeScale = 0f;
        gamestart.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "score")
        {
            manager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            isdead = true;
            Time.timeScale = 0f;

            gameover.SetActive(true);
        }
    }

    public void StartGame()
    {
        gamestart.SetActive(false);
        Time.timeScale = 1f;

    }

}
