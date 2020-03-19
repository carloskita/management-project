using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour
{

    float CurrentBalance;
    float BaseStoreCost;
    float BaseStoreProfit;

    int StoreCount;
    public Text StoreCountText;
    public Text CurrentBalanceText;
    public Slider ProgressSlider;

    float StoreTimer = 4f;
    float CurrentTimer = 0;
    bool StartTimer;

    // Start is called before the first frame update
    void Start()
    {

        StoreCount = 1;
        CurrentBalance = 2.0f;
        BaseStoreCost = 1.50f;
        BaseStoreProfit = .5f;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");
        StartTimer = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (StartTimer)
        {
            CurrentTimer += Time.deltaTime;
            if (CurrentTimer > StoreTimer)
            {
                Debug.Log("Time has ended. Reset.");
                StartTimer = false;
                CurrentTimer = 0f;
                CurrentBalance += BaseStoreProfit * StoreCount;
                CurrentBalanceText.text = CurrentBalance.ToString("C2");
            }
            ProgressSlider.value = CurrentTimer / StoreTimer;
        }
        ProgressSlider.value = CurrentTimer / StoreTimer;
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

    public void StoreOnClick()
    {
        Debug.Log("Clicked the store");
        if (!StartTimer)
        {
            StartTimer = true;
        }

    }
}
