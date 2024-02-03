using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] private bool isPlaceable;
    private void OnMouseOver()
    {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
        }
    }
}
