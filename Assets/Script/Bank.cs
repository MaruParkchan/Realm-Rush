using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] private int startingBalance = 150;

    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }


    private void Awake()
    {
        currentBalance = startingBalance;
    }

    public void Deposit(int amount) // 보증금, 잔고
    {
        currentBalance += Mathf.Abs(amount); // 절대값 바꾸기
    }

    public void WithDraw(int amount) // 빼기
    {
        currentBalance -= Mathf.Abs(amount);

        if (currentBalance <= -1)
        {
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
