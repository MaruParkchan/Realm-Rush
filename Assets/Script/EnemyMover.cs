using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    // Start is called before the first frame update
    void Start()
    {
        PirntWayPointName();
    }

    void PirntWayPointName()
    {
        foreach(WayPoint wayPoint in path)
        {
            Debug.Log(wayPoint.name);
        }
    }
}
