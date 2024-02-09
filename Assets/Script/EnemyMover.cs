using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField][Range(0.0f, 5.0f)] private float speed = 1.0f;
    private Enemy enemy;
    private void OnEnable()
    {
        FindPath();
        ReturnToStart();
        StartCoroutine(PirntWayPointName());
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void FindPath() // 경로 추가 및 정렬
    {
        path.Clear(); // 기존 경로 초기화

        GameObject parent = GameObject.FindGameObjectWithTag("Path");

        foreach (Transform child in parent.transform)
        {
            WayPoint wayPoint = child.GetComponent<WayPoint>();
            if (wayPoint != null)
            {
                path.Add(wayPoint);
            }
        }

       // path.Sort((a, b) => a.name.CompareTo(b.name)); // 오브젝트 경로 순서대로 정렬하기 
    }

    private void ReturnToStart() // 오브젝트 생성시 경로 처음 설정된 곳에서 나타나기 
    {
        transform.position = path[0].transform.position;
    }

    private void FinishPath()
    {
        enemy.StealGold();
        gameObject.SetActive(false);
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
        FinishPath();
    }
}
