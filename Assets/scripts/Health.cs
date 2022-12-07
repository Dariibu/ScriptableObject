using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] HealthValueSO _currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        _currentHealth.Health = 3;
    }

    public void Damaged(int damage)
    {
        Debug.Log("GotDamaged");
        _currentHealth.Health -= damage;
        if (_currentHealth.Health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Debug.Log("Died");
        _currentHealth.Health = 3;
    }
}
