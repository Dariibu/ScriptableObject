using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(menuName ="Data/HealthData")]

public class HealthValueSO : ScriptableObject
{

    [SerializeField] float _health;

    public float Health
    {
        get => _health;
        set
        {
            _health = value;
            OnHealthChange?.Invoke(_health);
        }
    }

    public event Action<float> OnHealthChange;

}
