using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Vector2 _direction;
    [SerializeField] float _speed;

    private void Start()
    {
        _rb.velocity = _direction * _speed;
    }




}
