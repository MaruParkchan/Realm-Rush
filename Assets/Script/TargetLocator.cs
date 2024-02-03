using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    private Transform target;

    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }
    void Update()
    {
        AimWeapon();
    }
    private void AimWeapon() // 적 방향으로 회전
    {
        transform.LookAt(target);
    }
}
