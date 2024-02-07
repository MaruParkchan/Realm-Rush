using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int goldReward = 25;
    [SerializeField] private int goldPenalty = 25;

    public Bank bank;

    private void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if (bank == null) { return; }
        bank.Deposit(goldReward);
    }

    public void StealGold()
    {
        if (bank == null) { return; }
        bank.WithDraw(goldPenalty);
    }
}
