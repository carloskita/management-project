using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    float CurrentBalance;
    public Text CurrentBalanceText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentBalance = 2.0f;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToBalance(float amt)
    {

        CurrentBalance += amt;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");

    }
}
