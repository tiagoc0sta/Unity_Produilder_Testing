using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealht;
    [SerializeField] GameObject _player; // new


    private Animator anim;
    private bool dead;

    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealht;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealht);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        } 
        else
        {
            if (!dead)
            {
                //anim.SetTrigger("die");
                _player.SetActive(false);
                //GetComponent<PlayerJoystickController>().enabled = false;
                //dead = true;
            }
            

        }
    }

    
}
