using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    public GameObject zigzagPanal;
    public GameObject gameOverPanal;
    public GameObject taptext;
    public Text score;
    public Text highScore;



    // making this Class Instance so we can access from other classes.
    public static UiManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }



    public void GameStart()
    {
        taptext.SetActive(false);
        zigzagPanal.GetComponent<Animator>().Play("ZigZag");
    }
    
    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanal.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }



}
