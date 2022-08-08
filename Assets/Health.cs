using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] int _maxHealth;

    public int CurrentHealth => _health;
    public int MaxHealth => _maxHealth;

    public event UnityAction OnDamage;
    public event UnityAction OnHeal;

    public void Damage(int damage)
    {
        // Code
        Debug.Log($"Aie j'ai perdu {damage} PV");

        _health = Mathf.Max(_health - damage, 0);           //  20-7=13  0

        if(_health <= 0)
        {
            Debug.Log("DEATH");
        }
        OnDamage.Invoke();
    }

    public void Heal(int healthToRestore)
    {
        // Code
        Debug.Log($"Ouiiii j'ai regagné {healthToRestore} PV");

        _health = Mathf.Min(_health + healthToRestore, _maxHealth);           // 200+10=220     200  
        OnHeal.Invoke();
    }

}
