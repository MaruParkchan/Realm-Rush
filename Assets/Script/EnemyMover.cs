using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] private float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PirntWayPointName());
    }

    IEnumerator PirntWayPointName()
    {
        foreach(WayPoint wayPoint in path)
        {
            //Debug.Log(wayPoint.name);
            transform.position = wayPoint.transform.position;
            yield return new WaitForSeconds(timer);
        }
    }
}
