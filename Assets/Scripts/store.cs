using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour
{

    float CurrentBalance;
    float BaseStoreCost;

    int StoreCount;
    public Text StoreCountText;
    public Text CurrentBalanceText;

    // Start is called before the first frame update
    void Start()
    {

        StoreCount = 1;
        CurrentBalance = 2.0f;
        BaseStoreCost = 1.50f;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyStoreOnClick()
    {

        if(BaseStoreCost > CurrentBalance)
        {
            return;
        }
        StoreCount += 1;
        Debug.Log(StoreCount);
        StoreCountText.text = StoreCount.ToString();
        CurrentBalance -= BaseStoreCost;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");
        Debug.Log(CurrentBalance);

    }
}
