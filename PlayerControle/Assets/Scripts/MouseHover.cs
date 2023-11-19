using UnityEngine;

public class MouseHover : MonoBehaviour
{

    private void OnMouseOver()
    {
        GameObject.Find("Player").transform.LookAt(transform.position);

    }

   
}
