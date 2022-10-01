using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealht;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealht;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealht);

        if (currentHealth > 0)
        {
            //player hurt
        } else
        {
            //player dead
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }
}
