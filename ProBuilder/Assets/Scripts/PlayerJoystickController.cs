using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickController : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    

    // Update is called once per frame
    void Update()
    {
        
        float hoz = moveJoystick.Horizontal;
        float ver = moveJoystick.Vertical;
        Vector3 direction = new Vector3(-ver, 0, hoz).normalized;
        transform.Translate(direction * 0.02f, Space.World);
    }

    
}
