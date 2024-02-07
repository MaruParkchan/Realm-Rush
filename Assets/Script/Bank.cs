using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] private int startingBalance = 150;

    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance;}}
    

    private void Awake() 
    {
        
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount); // 절대값 바꾸기
    }

    public void WithDraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
    }
}
