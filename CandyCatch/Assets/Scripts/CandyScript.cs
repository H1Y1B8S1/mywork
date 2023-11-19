
using UnityEngine;

public class CandyScript : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //increase score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

        else if(collision.gameObject.tag == "Boundary")
        {   
            //decrease lives
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
