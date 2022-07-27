using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _spawnCooldown;

    float _lastShoot;

    void Update()
    {
        //Random.
        float rx = Random.Range(-1f, 1f);
        float ry = Random.Range(-1f, 1f);
        Vector3 randomDirection = new Vector3(rx, ry);

        if(Time.time > _lastShoot + _spawnCooldown)
        {
            _lastShoot = Time.time;
            GameObject.Instantiate(_bulletPrefab, transform.position + randomDirection, transform.rotation);
        }

    }




}
