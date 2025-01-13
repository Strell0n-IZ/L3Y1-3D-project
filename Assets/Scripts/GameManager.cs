using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    public float timer;
    public float timeLimit;
    public TMP_Text timerText;

    [Header("Collectables")]
    public int RequireCollectables;
    public int currentCollectables;
    public TMP_Text collectablesText;

    void Start()
    {
        timer = timeLimit;
    }
    void Update()
    {
        GameTimer();
        Collectables();
    }

    void GameTimer()
    {
        timerText.text = timer.ToString("F2");

        if(timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
    }
    void Collectables()
    {
        collectablesText.text = currentCollectables + " / " + RequireCollectables;

        if (currentCollectables == RequireCollectables)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
