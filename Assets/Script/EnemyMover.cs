using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] [Range(0.0f, 5.0f)] private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PirntWayPointName());
    }

    IEnumerator PirntWayPointName()
    {
        foreach (WayPoint wayPoint in path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = wayPoint.transform.position;
            float travelpercent = 0.0f;

            transform.LookAt(endPosition);
            while (travelpercent < 1.0f)
            {
                travelpercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelpercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
