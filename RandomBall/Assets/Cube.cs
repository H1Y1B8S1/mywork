using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject[] Ball;
    void Start()
    {
        //Invoke("RandomBall", 1f);
        InvokeRepeating("RandomBall", 1f,1f);

    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            CancelInvoke("RandomBall");
        }
    }


    void RandomBall()
    {
        int randomNumber = Random.Range(0,Ball.Length);
        Instantiate(Ball[randomNumber], transform.position, Quaternion.identity);


    }
}
