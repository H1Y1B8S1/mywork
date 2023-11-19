using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
        
    }

    void Update()
    {
        // this will return the v3 value of direction toward the target.
        Vector3 direction = target.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = targetRotation;

    }





}
