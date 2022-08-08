using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MyButtonBehavior : MonoBehaviour
{
    [SerializeField] Button _buttonToControl;

    [SerializeField] UnityEvent _onPressed;
    [SerializeField] UnityEvent _onReleased;

    bool _isPressed;

    private void Start()
    {
        _buttonToControl.onClick.AddListener(MaFonction);
        _isPressed = false;
    }

    public void _ForceRelease()
    {
        _isPressed = false;
        _onReleased.Invoke();
    }

    void MaFonction()
    {
        // Je met à jour l'état du bouton
        if (_isPressed == true)
        {
            _isPressed = false;
            _onReleased.Invoke();
        }
        else
        {
            _isPressed = true;
            _onPressed.Invoke();
        }

    }
}
    