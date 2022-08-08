using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] Transform[] _windows;

    public void ShowPanel(Transform panelToActivate)
    {
        foreach (var window in _windows)
        {
            if (window != panelToActivate)
            {
                window.gameObject.SetActive(false);
            }
            else
            {
                window.gameObject.SetActive(true);
            }
        }

        // Même chose
        for (int i = 0; i < _windows.Length; i++)
        {
            if (_windows[i] != panelToActivate)
            {
                _windows[i].gameObject.SetActive(false);
            }
            else
            {
                _windows[i].gameObject.SetActive(true);
            }
        }
    }
}
