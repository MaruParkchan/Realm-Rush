using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHitPoints = 5;
    [SerializeField] private int currentHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHitPoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
