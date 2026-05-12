using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : Stats
{
    [SerializeField]
    private Slider  healthSlider;
    [SerializeField]
    private Slider  shieldSlider;
    [SerializeField]
    private Slider  manaSlider;
    [SerializeField]
    private Slider  staminaSlider;
    [SerializeField]
    private Slider  expSlider;
    
    [SerializeField]
    protected int _strength;
    [SerializeField]
    protected int _dexterity;
    [SerializeField]
    protected int _intelligence;

    [SerializeField]
    protected int _maxExp;
    [SerializeField]
    protected int _currentExp ;

    public int Strength => _strength;
    public int Dexterity => _dexterity;
    public int Intelligence => _intelligence;

    private void Update()
    {
        UpdateSliders();
    }

    public void UpdateSliders()
    {
        healthSlider.value = (float)_currentHp / (float)_maxHp;
        shieldSlider.value = (float)_currentShield / (float)_maxShield;
        manaSlider.value = (float)_currentMana / (float)_maxMana;
        staminaSlider.value = (float)_currentStamina / (float)_maxStamina;
        expSlider.value = (float)_currentExp / (float)_maxExp;
    }


}
