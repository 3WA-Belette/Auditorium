using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCubePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;

    private void Reset()
    {
        _speed = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log(horizontalInput);

        Vector3 direction = new Vector3(horizontalInput, 0 , verticalInput) * Time.fixedDeltaTime * _speed;
        
        //transform.Translate(direction);

        _rb.MovePosition(transform.position + direction);
    }
}
