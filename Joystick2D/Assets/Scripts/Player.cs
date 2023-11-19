using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public FixedJoystick joystick;
    float hInput,vInput;


    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical*moveSpeed;

        transform.Translate(hInput, vInput, 0);
    }

}
