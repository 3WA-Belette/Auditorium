using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;

    void Update()
    {
        GameObject.Instantiate(_bulletPrefab, transform.position, transform.rotation);
    }

}
