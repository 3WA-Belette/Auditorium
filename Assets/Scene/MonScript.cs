using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScript : MonoBehaviour
{
    int healthField = 100;

    private void Start()
    {
        Debug.Log("Start");
    }
    private void Update()
    {
        Debug.Log("Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    public void Damage(int power, int resistance)
    {
        healthField = healthField - power;
        Debug.Log("ouie");
        if(healthField < 0)
        {
            Debug.Log("dead");

        }
    }



















    void MonStartCustom()
    {

        Damage(10);



    }














}
