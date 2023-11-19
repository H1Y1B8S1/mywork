
using System.Collections;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]float maxX;
    public GameObject[] Candies;

    [SerializeField] float spawnInterval;

    public static CandySpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartSpawningCandies();
    }


    void SpawnCandy()
    {
        // Random candies index
        int rand = Random.Range(0, Candies.Length);
        // Random x position 
        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX,transform.position.y, transform.position.z);


        Instantiate(Candies[rand],randomPos,transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }
    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }


}
