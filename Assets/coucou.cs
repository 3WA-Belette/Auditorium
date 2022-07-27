using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coucou : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        var t = GetComponent<MonScript>();

        t.Damage(12,20);
        t.Damage(12);
        t.Damage(12);
        t.Damage(12);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
