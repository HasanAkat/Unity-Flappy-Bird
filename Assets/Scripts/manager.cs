using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public int score;
    public Text tscore;

    public void Start()
    {
        score = 0;
        tscore.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        tscore.text = score.ToString();
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
}
