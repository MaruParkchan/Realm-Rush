using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITest
{
    int PlayerHp {get; set;}
    string Names {get; set;}
    public void Move();


}

[ExecuteAlways]
public class Test : MonoBehaviour, ITest
{
    private int playerHp;
    // Start is called before the first frame update
    public int PlayerHp
    {
        get { return playerHp;}
        set { playerHp = value;}
    }

    public string Names
    {
        get; set;
    }
    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // if (!Application.isPlaying)
        // {
        //     Move();
        // }

    }

    public void Move()
    {
        Debug.Log("11");
    }

}
