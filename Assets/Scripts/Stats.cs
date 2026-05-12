using System;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField]
    protected int _maxHp;
    [SerializeField]
    protected int _currentHp;
    
    [SerializeField]
    protected int _maxShield;
    [SerializeField]
    protected int _currentShield;
    
    [SerializeField]
    protected int _maxMana;
    [SerializeField]
    protected int _currentMana;
    
    [SerializeField]
    protected int _maxStamina;
    [SerializeField]
    protected int _currentStamina;
    
    [SerializeField]
    protected int _attack;
    [SerializeField]
    protected int _defense;

    public int Hp => _maxHp;
    public int CurrentHp => _currentHp;

    public int Shield => _maxShield;
    public int CurrentShield => _currentShield;

    public int Mana => _maxMana;
    public int CurrentMana => _currentMana;

    public int Stamina => _maxStamina;
    public int CurrentStamina => _currentStamina;

    public int Attack => _attack;
    public int Defense => _defense;

    public void GetDamage(int damage)
    {
        if (_defense < damage)
        {
            _currentHp -= (damage -  _defense);
        }
        else
        {
            _currentHp -= 1;
        }

        if (_currentHp > 0) return;
        _currentHp = 0;
        Die();
    }

    protected void Die()
    {
        Debug.Log(this.gameObject.name + " died");
    }
}
