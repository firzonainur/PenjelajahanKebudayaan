using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsLev1 : MonoBehaviour
{
    Text hitungCoinText;
    public int jumlahItem;


    void Start()
    {
        PlayerPrefs.SetInt("akumulasiCoin1", 0);
        hitungCoinText = GetComponent<Text>();
    }

    void Update()
    {
        hitungCoinText.text = PlayerPrefs.GetInt("akumulasiCoin1").ToString();
    }
}
