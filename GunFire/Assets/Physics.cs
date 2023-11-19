using UnityEngine;

public class Physics : MonoBehaviour
{
    Rigidbody rb;
    float inputX, inputY;
    bool jump = false;
    public int jumpForce;
    public int speed;

    public GameObject bullet;
    public float bulletSpeed;
    bool shoot = false;
    public Transform bulletPos;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Start()
    {

    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            shoot = true;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(inputX * speed, rb.velocity.y, inputY * speed);

        if (jump)
        {
            Jump();
            jump = false;
        }

        if (shoot)
        {
            Shoot(); 
            shoot = false;
        }
    }


    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }

    void Shoot()
    {
        GameObject bulletspawn = Instantiate(bullet,bulletPos.position,bullet.transform.rotation);
        bulletspawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
        Destroy(bulletspawn,0.5f);
    }
}
