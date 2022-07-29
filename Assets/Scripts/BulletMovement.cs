using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Vector2 _direction;
    [SerializeField] float _speed;

    [SerializeField] float _lifespan;

    float _remainingTime;   // Methode deltaTime

    //float _futurDestroyDate;    // Methode Time.time


    private void Start()
    {
        _rb.velocity = _direction * _speed;

        // Methode DeltaTime
        _remainingTime = _lifespan;

        // Methode Time.time
        //_futurDestroyDate = Time.time + _lifespan;
    }

    private void Update()
    {
        // Methode DeltaTime
        _remainingTime = _remainingTime - Time.deltaTime;
        if (_remainingTime < 0) 
        {
            GameObject.Destroy(gameObject);
        }

        // Methode Time.time
        //if(Time.time> _futurDestroyDate)
        //{
        //    GameObject.Destroy(gameObject);
        //}
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Destroy(gameObject);
        //Debug.Log("Touché");

    }

}
