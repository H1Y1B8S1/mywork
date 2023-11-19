using UnityEngine;

public class CamaraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;
    public float distance = 5;


    void Update()
    {

        transform.position = target.position - new Vector3(0, 0, distance);
    }
}
