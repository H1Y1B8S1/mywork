using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    float ad, ws;
    public float moveSpeed = 50f;

    Vector3 temPosition;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = transform.forward * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = -transform.forward * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
        }

    }


}
