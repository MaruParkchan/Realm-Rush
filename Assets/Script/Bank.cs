using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] private int startingBalance = 150;
    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }

    [SerializeField] TextMeshProUGUI displayBalance;


    private void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }

    public void Deposit(int amount) // 보증금, 잔고
    {
        currentBalance += Mathf.Abs(amount); // 절대값 바꾸기
        UpdateDisplay();
    }

    public void WithDraw(int amount) // 빼기
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();

        if (currentBalance <= -1)
        {
            ReloadScene();
        }
    }

    private void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    private void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
