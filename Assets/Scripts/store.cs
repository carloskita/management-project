using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour
{

    public float BaseStoreCost;
    public float BaseStoreProfit;


    int StoreCount;
    public Text StoreCountText;
    public Slider ProgressSlider;
    public gameManager GameManager;

    public float StoreTimer = 3f;
    float CurrentTimer = 0;
    bool StartTimer;

    // Start is called before the first frame update
    void Start()
    {

        StoreCount = 1;
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
                GameManager.AddToBalance(BaseStoreProfit * StoreCount);
            }
            ProgressSlider.value = CurrentTimer / StoreTimer;
        }
        ProgressSlider.value = CurrentTimer / StoreTimer;
    }

    public void BuyStoreOnClick()
    {

        if(!GameManager.CanBuy(BaseStoreCost))
        {
            return;
        }
        StoreCount += 1;
        Debug.Log(StoreCount);
        StoreCountText.text = StoreCount.ToString();
        GameManager.AddToBalance(-BaseStoreCost);

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
