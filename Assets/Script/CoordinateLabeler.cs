using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    private TextMeshPro label;
    private Vector2Int coordinates = new Vector2Int();

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisPlayCoordinates();
    }

    private void Update()
    {
        if (!Application.isPlaying) // 플레이중 아닐때 업데이트 
        {
            DisPlayCoordinates();
            UpdateObjectName();
        }
    }

    void DisPlayCoordinates() // 좌표 설정
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName() // 오브젝트 이름 좌표 실시간 바꾸기 
    {
        transform.parent.name = coordinates.ToString();
    }
}
