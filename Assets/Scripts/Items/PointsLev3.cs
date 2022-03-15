using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsLev3 : MonoBehaviour
{
    public static int akumulasiCoin;
    Text hitungCoinText;
    public int jumlahItem;


    void Start()
    {
        PlayerPrefs.SetInt("akumulasiCoin3", 0);
        hitungCoinText = GetComponent<Text>();
    }

    void Update()
    {
        hitungCoinText.text = PlayerPrefs.GetInt("akumulasiCoin3").ToString();
    }
}

