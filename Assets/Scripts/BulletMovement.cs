using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Vector2 _direction;
    [SerializeField] float _speed;

    [SerializeField] float _lifespan;

    float _startLife;

    private void Start()
    {
        _rb.velocity = _direction * _speed;
        _startLife = Time.time;
    }

    private void Update()
    {
        if(Time.time > _startLife+_lifespan)
        {
            GameObject.Destroy(gameObject);
        }

    }



}
