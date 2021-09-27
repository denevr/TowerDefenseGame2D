using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Text finalScoreText;
    public Button restartButton;

    void Start()
    {
        restartButton.onClick.AddListener(OnRestartButtonClick);
        finalScoreText.text = " Enemies Killed: " + Scoreboard.score.ToString() + " ";
    }

    void Update()
    {

    }

    void OnRestartButtonClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
