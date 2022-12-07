using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour
{

    [SerializeField] int _speedReduction = 500;

    void Update()
    {
        transform.position +=Vector3.Normalize(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0)) / _speedReduction;
    }
}
