using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;




    public static GameManager instance;
    private void Awake()
    {
        if (instance == null) 
        { instance = this; }
    }



    void Start()
    {
        gameOver = false;
    }

 

    public void StartGame()
    {
        UiManager.Instance.GameStart();
        ScoreManager.instance.StartScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawningPlatforms();
    }

    public void GameOver()
    {
        UiManager.Instance.GameOver();
        ScoreManager.instance.StopScore();
        gameOver = true;
    }

}
