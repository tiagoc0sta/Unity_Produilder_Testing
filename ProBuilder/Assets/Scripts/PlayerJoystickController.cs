using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickController : MonoBehaviour
{
    public FixedJoystick moveJoystick;


    [SerializeField] private Animator m_animator = null;

    //Animation states
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_WALK = "Walk";

    private Rigidbody rb2d;
    private Animator animator;
    private string currentState;
    private float xAxis;
    private float yAxis;

    //Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
         
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;       

    }
    

    // Update is called once per frame ////////
    void Update()
    {
        xAxis = moveJoystick.Horizontal;
        yAxis = moveJoystick.Vertical;


    }

    //phisics based time step loop
    private void FixedUpdate()
    {
        
        
        if (xAxis !=0 || yAxis !=0)
        {
            float hoz = moveJoystick.Vertical;
            float ver = moveJoystick.Horizontal;
            Vector3 direction = new Vector3(-ver, 0, -hoz).normalized;
            transform.Translate(direction * 0.02f, Space.World);
            ChangeAnimationState("Walk");
        }
        else
        {
            ChangeAnimationState("Idle");
        }
        
    }

}

    

