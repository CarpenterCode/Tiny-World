using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    [SerializeField] Text countCoin, countCoin1;

    public int countCoins = 0;


    private void Update()
    {
        countCoin.text = countCoins.ToString();
        countCoin1.text = countCoins.ToString();
    }
}
