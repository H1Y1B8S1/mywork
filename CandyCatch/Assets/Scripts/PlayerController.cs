
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;
    [SerializeField] float moveSpeed;
    [SerializeField] float maxPos;


    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
        //transform.position += new Vector3(inputX*moveSpeed*Time.deltaTime, 0, 0);

        //Setting the boundries for the players movement by clamping the value of x axis.
        float xpos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xpos, transform.position.y, transform.position.z);

       

    }
}
