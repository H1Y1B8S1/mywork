using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    Rigidbody rb;
    bool started;
    bool gameOver;
    public GameObject partical;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        started = false;
        gameOver = false;
    }

    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(ballSpeed, 0, 0);
                started = true;

                GameManager.instance.StartGame();

            }
        }
        Debug.DrawLine(transform.position, Vector3.down, Color.red);


        if (!Physics.Raycast(transform.position, Vector3.down, 2f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -10f, 0);

            Camera.main.GetComponent<cameraFollow>().gameOver = gameOver;
            
            GameManager.instance.GameOver();
        }


        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }

    }

    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(ballSpeed, 0, 0);
        }
        else if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, ballSpeed);
        }
    }

    // Diamond distroy after collect
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Diamond")
        {
            // partical effect added and distroyed after 1sec also diamond distoyed.
            GameObject part = Instantiate(partical, col.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(col.gameObject);
            Destroy(part,1f);
        }
    }
}
