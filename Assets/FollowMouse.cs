using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;

    Vector2 _oldMousePosition;

    private void OnMouseDown()
    {
        Debug.Log("Down");
        _oldMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        Vector2 currentMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log($"MousePosition {Input.mousePosition} World {currentMousePosition}");
        transform.Translate(currentMousePosition - _oldMousePosition, Space.World);
        // FIN
        _oldMousePosition = currentMousePosition;
    }

}
