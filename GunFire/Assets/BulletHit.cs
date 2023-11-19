using UnityEngine;

public class BulletHit : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            if (collision.gameObject.GetComponent<Renderer>().material.color == Color.white)
            {
                collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
                Destroy(collision.gameObject);
            }
            
            
        }
    }
}
