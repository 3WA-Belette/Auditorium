using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBis : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] float _duration;

    float _oldDate;
    float _newDate;

    private void Start()
    {
        _oldDate = Time.time;
        _newDate = _oldDate + _duration;
    }

    private void Update()
    {
        if(Time.time > _newDate)
        {
            GameObject.Instantiate(_prefab, transform.position, transform.rotation);
            _newDate = Time.time + _duration;
        }

    }

}
