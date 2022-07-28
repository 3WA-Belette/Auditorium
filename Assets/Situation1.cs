using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Situation1 : MonoBehaviour
{
    bool _onADejaLogg�;
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void Start()
    {
        Debug.Log("Start");
    }
    private void Update()
    {
        if(_onADejaLogg� == false)
        {
            Debug.Log("Update");
        }
    }
    private void LateUpdate()
    {
        if(_onADejaLogg� == false)
        {
            Debug.Log("LateUpdate");
        }
        _onADejaLogg� = true;
    }
}
