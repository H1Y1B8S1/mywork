
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    public GameObject RestartButton;


    public void ScoreUp()
    {
        score++;

        if (score >= 5)
        {
            Win();
        }
    }

    void Win()
    {
        winText.SetActive(true);
        RestartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

}
