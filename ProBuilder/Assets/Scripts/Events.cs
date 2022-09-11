using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Events : MonoBehaviour
{
    public UnityEvent enteredStairs;
    public UnityEvent exitedStairs;

    private void OnTriggerEnter(Collider other)
    {
        enteredStairs.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        exitedStairs.Invoke();
    }

////////
}

