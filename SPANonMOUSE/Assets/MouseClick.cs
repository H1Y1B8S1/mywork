using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject cube;



    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10f;
            pos = Camera.main.ScreenToWorldPoint(pos);


            Instantiate(cube, pos, Quaternion.identity);
        }
    }

}
