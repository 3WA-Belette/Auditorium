using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceGizmo : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;

    [SerializeField] CircleCollider2D _areaCircle;
    [SerializeField] AreaEffector2D _areaEffector;

    Vector2 _oldMousePosition;

    void OnMouseDown()
    {
        Debug.Log("Down on influencer");
        _oldMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        Debug.Log("Drag on Influencer");
        Vector2 currentMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 position2D = transform.position;
        float distance = Vector2.Distance(position2D, currentMousePosition);

        Debug.Log($"Origin Position {position2D}");
        Debug.Log($"Cursor Position {currentMousePosition}");
        Debug.Log($"Distance {distance}");

        _areaCircle.radius = distance;
        transform.localScale = new Vector3(distance, distance, distance);

        // FIN
        _oldMousePosition = currentMousePosition;
    }

}
