using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] GameObject _bullet;

    private void Start()
    {
        InvokeRepeating("Shooting", 2, 1);
        InvokeRepeating("RandomMove", 5, 3);
    }

    void Shooting()
    {
        Instantiate(_bullet, transform.position, Quaternion.identity);
    }

    void RandomMove()
    {
        transform.position =new Vector2(transform.position.x, Random.Range(-2.5f, 3));
    }

}
