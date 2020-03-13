using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour
{

    int StoreCount;
    public Text StoreCountText;

    // Start is called before the first frame update
    void Start()
    {

        StoreCount = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyStoreOnClick()
    {

        StoreCount += 1;
        Debug.Log(StoreCount);
        StoreCountText.text = StoreCount.ToString();

    }
}
