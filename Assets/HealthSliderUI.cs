using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSliderUI : MonoBehaviour
{
    [SerializeField] Health _player;
    [SerializeField] Slider _slider;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        UpdateSlider();

        _player.OnDamage += UpdateSlider;
        _player.OnHeal += UpdateSlider;
    }

    private void OnDestroy()
    {
        _player.OnDamage -= UpdateSlider;
        _player.OnHeal -= UpdateSlider;
    }

    private void Update()
    {
        // _slider.value = _player.CurrentHealth;
        // Debug.Log($"JE MET À JOUUUUUUUR {_slider.value}");
    }

    void UpdateSlider()
    {
        _slider.value = _player.CurrentHealth;
        Debug.Log($"JE MET À JOUUUUUUUR {_slider.value}");
    }

}
