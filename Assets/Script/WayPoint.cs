using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] private Tower towerPrefab;
    [SerializeField] private bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable;} }

    private void OnMouseDown() // IsPlaceable는 해당 블럭위에 타워를 설치해도 되는지?
    {
        if (isPlaceable)
        {
            bool isPlaced =  towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = !isPlaced;
        }
    }
}
