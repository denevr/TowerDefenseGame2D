using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Start()
    {
        score = 0;
        scoreText.text = " Enemies Killed: " + score.ToString() + " ";
    }

    void Update()
    {
        scoreText.text = " Enemies Killed: " + score.ToString() + " ";
    }
}
