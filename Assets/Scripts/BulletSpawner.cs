using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _spawnCooldown;
    [SerializeField] float _circleSize;

    [SerializeField] Color _gizmoColor;

    float _lastShoot;

    void Update()
    {
        //Methode 1
        //float rx = Random.Range(_min, _max);
        //float ry = Random.Range(_min, _max);
        //Vector3 randomDirection = new Vector3(rx, ry);

        // Methode 2
        Vector3 randomDirection = Random.insideUnitCircle * _circleSize;
        if(Time.time > _lastShoot + _spawnCooldown)
        {
            _lastShoot = Time.time;
            GameObject.Instantiate(_bulletPrefab, transform.position + randomDirection, transform.rotation);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmoColor;
        Gizmos.DrawSphere(transform.position, _circleSize);
    }

}
