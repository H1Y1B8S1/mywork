using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public Text scoreText;
    public GameObject livesHolder;
    public GameObject gameOverPanel;




    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }



    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;


            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver() 
    {
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {

        SceneManager.LoadScene("Menu");
    }
}
