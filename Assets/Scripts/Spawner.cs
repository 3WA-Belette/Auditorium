using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Configuration du GD")]
    [SerializeField] GameObject _prefab;
    [SerializeField] float _cooldown;

    [Header("Variable qui évolue avec le temps")]
    float _cooldownRemaining;

    void Start()
    {
        _cooldownRemaining = _cooldown;
    }

    private void Update()
    {
        _cooldownRemaining = _cooldownRemaining - Time.deltaTime;
        if(_cooldownRemaining < 0)
        {
            _cooldownRemaining = _cooldown;
            GameObject.Instantiate(_prefab, transform.position, transform.rotation);
        }

    }
}
