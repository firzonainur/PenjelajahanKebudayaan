using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsLev2 : MonoBehaviour
{
    public static int akumulasiCoin;
    Text hitungCoinText;
    public int jumlahItem;


    void Start()
    {
        PlayerPrefs.SetInt("akumulasiCoin2", 0);
        hitungCoinText = GetComponent<Text>();
    }

    void Update()
    {
        hitungCoinText.text = PlayerPrefs.GetInt("akumulasiCoin2").ToString();
    }
}
