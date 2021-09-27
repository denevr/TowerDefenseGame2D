using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GameOver;
    public Vector3 offset = new Vector3(0.0f, 19, -4.5f); 

    void Start()
    {
        GameOver = false;
    }

    void Update()
    {
        if (Scoreboard.score == 15)
            EndGame();
        if (GameOver)
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);

    }

    void EndGame()
    {
        GameOver = true;
    }
}
