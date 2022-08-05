using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;
    [SerializeField] Transform _transformToMove;

    Vector2 _oldMousePosition;

    private void OnMouseDown()
    {
        Debug.Log("Follow mouse Down");
        _oldMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        Debug.Log("Follow mouse Drag");
        Vector2 currentMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log($"MousePosition {Input.mousePosition} World {currentMousePosition}");

        Vector2 deltaCursorPosition = currentMousePosition - _oldMousePosition;
        _transformToMove.Translate(deltaCursorPosition, Space.World);
        // FIN
        _oldMousePosition = currentMousePosition;
    }
}
